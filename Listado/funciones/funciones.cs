using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;
using Aspose.Words;
using Aspose.Words.Replacing;
using System.Diagnostics;
using System.IO;

namespace RaquetZone.funciones
{

    


    public static class funciones
    {


        //Lista para los usuarios
        public static List<usuario> mostrarUsr()
        {

            String url = "http://localhost:8081/usuarios";

            conexion r = new conexion(url, "GET");

            String user = r.getItem();

            List<usuario> RaquetZoneUsr = JsonConvert.DeserializeObject<List<usuario>>(user);

            return RaquetZoneUsr;

        }

        //Lista para las empresas
        public static List<empresa> mostrarEmp()
        {
            String url = "http://localhost:8081/empresas";

            conexion r = new conexion(url, "GET");

            String compa = r.getItem();

            List<empresa> RaquetZoneEmp = JsonConvert.DeserializeObject<List<empresa>>(compa);

            return RaquetZoneEmp;

        }

        //Lista para los productos
        public static List<productos> mostrarProd()
        {
            String url = "http://localhost:8081/productos";

            conexion r = new conexion(url, "GET");

            String produ = r.getItem();

            List<productos> RaquetZoneProd = JsonConvert.DeserializeObject<List<productos>>(produ);

            return RaquetZoneProd;

        }

        //Lista para los clientes
        public static List<clientes> mostrarCli()
        {
            String url = "http://localhost:8081/clientes";

            conexion r = new conexion(url, "GET");

            String persona = r.getItem();

            List<clientes> RaquetZoneCli = JsonConvert.DeserializeObject<List<clientes>>(persona);

            return RaquetZoneCli;

        }


        //Lista para las compras
        public static List<compras> mostrarComp()
        {
            String url = "http://localhost:8081/compras";

            conexion r = new conexion(url, "GET");

            String buy = r.getItem();

            List<compras> RaquetZoneComp = JsonConvert.DeserializeObject<List<compras>>(buy);

            return RaquetZoneComp;

        }

        //Lista para las compras ordenadas por fecha
        public static List<compras> mostrarCompFecha()
        {
            String url = "http://localhost:8081/compras/fecha";

            conexion r = new conexion(url, "GET");

            String buyF = r.getItem();

            List<compras> RaquetZoneComp = JsonConvert.DeserializeObject<List<compras>>(buyF);

            return RaquetZoneComp;

        }

        //Lista para los servicios
        public static List<servicios> mostrarServicio()
        {
            String url = "http://localhost:8081/servicios";

            conexion r = new conexion(url, "GET");

            String Serv = r.getItem();

            List<servicios> RaquetZoneServ = JsonConvert.DeserializeObject<List<servicios>>(Serv);

            return RaquetZoneServ;

        }

        //Enviar emails

        public static void sendEmail(string dirigido, string body, string subject)
        {
            try {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("RaquetZone9@gmail.com");
                    mail.To.Add(dirigido);
                    mail.Subject = subject;
                    mail.Body = body;
                    //mail.Body = "<h1>This is body</h1>";
                    //mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("RaquetZone9@gmail.com", "llhfuvfgmugzrxsv");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Crear PDF's y editarlos

        public static void facturasPDF(string id, string fecha)
        {

            // string descuento, string total, string precio, string nombre, string cantidad

            Document doc = new Document("Factura.docx");
            doc.Range.Replace("$nombre", id, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$fecha", fecha, new FindReplaceOptions(FindReplaceDirection.Forward));
            /*doc.Range.Replace("$descuento", descuento, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$precio", precio, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$total", total, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$nombre1", nombre, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$cantidad", cantidad, new FindReplaceOptions(FindReplaceDirection.Forward));
            */
            string nombreFac = "Factura" + id + ".pdf";

            string rutaMala = @"D:\Clase_Segundo\Interfaces\Listado\Listado\bin\Debug\" + nombreFac;
            string rutaBuena = @"D:\Clase_Segundo\Interfaces\Listado\Listado\Facturas\" + nombreFac;

            //Comprobamos primero que no existe el archivo antes de crearlo

            DirectoryInfo di = new DirectoryInfo(@"E:\Clase_Segundo\Interfaces\Listado\Listado\Facturas");
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name.Equals(nombreFac))
                {
                    File.Delete(rutaBuena);
                }
            }

            doc.Save(nombreFac);
           
            File.Move(rutaMala, rutaBuena);

            Process proceso = new Process();
            proceso.StartInfo.FileName = rutaBuena;
            proceso.Start();
        }

        public static bool IsNumeric(this string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

    }

}
