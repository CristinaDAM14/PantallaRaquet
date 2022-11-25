using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;
using Aspose.Words.Saving;
using Aspose.Words.Loading;
using Aspose.Words;
using Aspose.Words.Replacing;
using System.Diagnostics;

namespace RaquetZone.funciones
{

    


    public class funciones
    {


        //Lista para los usuarios
        public static List<usuario> mostrarUsr()
        {

            String url = "http://localhost:8081/usuarios";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String user = r.getItem();

            List<usuario> RaquetZoneUsr = JsonConvert.DeserializeObject<List<usuario>>(user);

            return RaquetZoneUsr;

        }

        //Lista para las empresas
        public static List<empresa> mostrarEmp()
        {
            String url = "http://localhost:8081/empresa";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String compa = r.getItem();

            List<empresa> RaquetZoneEmp = JsonConvert.DeserializeObject<List<empresa>>(compa);

            return RaquetZoneEmp;

        }

        //Lista para los productos
        public static List<productos> mostrarProd()
        {
            String url = "http://localhost:8081/productos";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String produ = r.getItem();

            List<productos> RaquetZoneProd = JsonConvert.DeserializeObject<List<productos>>(produ);

            return RaquetZoneProd;

        }

        //Lista para los clientes
        public static List<clientes> mostrarCli()
        {
            String url = "http://localhost:8081/cliente";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String persona = r.getItem();

            List<clientes> RaquetZoneCli = JsonConvert.DeserializeObject<List<clientes>>(persona);

            return RaquetZoneCli;

        }


        //Lista para las compras
        public static List<compras> mostrarComp()
        {
            String url = "http://localhost:8081/compras";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String buy = r.getItem();

            List<compras> RaquetZoneComp = JsonConvert.DeserializeObject<List<compras>>(buy);

            return RaquetZoneComp;

        }

        //Lista para las compras ordenadas por fecha
        public static List<compras> mostrarCompFecha()
        {
            String url = "http://localhost:8081/compras/fecha";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String buyF = r.getItem();

            List<compras> RaquetZoneComp = JsonConvert.DeserializeObject<List<compras>>(buyF);

            return RaquetZoneComp;

        }

        //Enviar emails

        public static void sendEmail(string dirigido, string body)
        {
            try {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("RaquetZone9@gmail.com");
                    mail.To.Add(dirigido);
                    mail.Subject = body;
                    //mail.Body = "<h1>This is body</h1>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("RaquetZone9@gmail.com", "llhfuvfgmugzrxsv");
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
            Document doc = new Document("Factura.docx");
            doc.Range.Replace("$nombre", id, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$fecha", fecha, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Save("Factura.pdf");

            Process proceso = new Process();
            proceso.StartInfo.FileName = @"E:\Clase_Segundo\Interfaces\Listado\Listado\bin\Debug\Factura.pdf";
            proceso.Start();
        }

    }
}
