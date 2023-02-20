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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;

namespace RaquetZone.funciones
{

    public static class funciones
    {


        //Lista para los usuarios
        public static List<usuario> mostrarUsr()
        {

            String url = ConfigurationManager.AppSettings["AccesoBD"] + "usuarios";

            conexion r = new conexion(url, "GET");

            String user = r.getItem();

            if (user.Equals("[]"))
            {
                return null;

            }
            else
            {
                List<usuario> RaquetZoneUsr = JsonConvert.DeserializeObject<List<usuario>>(user);

                return RaquetZoneUsr;
            }
            

        }

        //Lista para los empleados de un propietario
        public static List<usuario> mostrarUsrP(string cif)
        {

            String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + cif + "/empleados";

            conexion r = new conexion(url, "GET");

            String user = r.getItem();

            if (user.Equals("[]"))
            {
                return null;

            }
            else
            {
            List<usuario> RaquetZoneUsr = JsonConvert.DeserializeObject<List<usuario>>(user);

            return RaquetZoneUsr;
            }

            

        }

        //Lista para las empresas
        public static List<empresa> mostrarEmp()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresas";

            conexion r = new conexion(url, "GET");

            String compa = r.getItem();

            if (compa.Equals("[]"))
            {
                return null;

            }
            else
            {
            List<empresa> RaquetZoneEmp = JsonConvert.DeserializeObject<List<empresa>>(compa);

            return RaquetZoneEmp;
            }

        }

        //Lista para los productos
        public static List<productos> mostrarProd()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "productos";

            conexion r = new conexion(url, "GET");

            String produ = r.getItem();

            if (produ.Equals("[]"))
            {
                return null;

            }
            else
            {
            List<productos> RaquetZoneProd = JsonConvert.DeserializeObject<List<productos>>(produ);

            return RaquetZoneProd;
            }

        }

        //Lista para los productos del propietario
        public static List<productos> mostrarProdP(string cif)
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + cif + "/productos";

            conexion r = new conexion(url, "GET");

            String produ = r.getItem();

            if (produ.Equals("[]"))
            {
                return null;

            }
            else
            {
                produ = produ.Replace("\"empresa\":{", "");
                produ = produ.Replace("]}", "]");
                produ = produ.Replace("}}", "}");


                List<productos> RaquetZoneProd = JsonConvert.DeserializeObject<List<productos>>(produ);

            return RaquetZoneProd;
            }

            

        }

        //Lista para los clientes
        public static List<clientes> mostrarCli()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "clientes";

            conexion r = new conexion(url, "GET");

            String persona = r.getItem();

            if (persona.Equals("[]"))
            {
                return null;

            }
            else
            {
            List<clientes> RaquetZoneCli = JsonConvert.DeserializeObject<List<clientes>>(persona);

            return RaquetZoneCli;
            }

        }

        //Lista para los clientes de un propietario
        public static List<clientes> mostrarCliP(string cif)
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + cif + "/clientes";

            conexion r = new conexion(url, "GET");

            String persona = r.getItem();

            if (persona.Equals("[]"))
            {
                return null;

            }
            else
            {
                List<clientes> RaquetZoneCli = JsonConvert.DeserializeObject<List<clientes>>(persona);

                return RaquetZoneCli;
            }
           

        }


        //Lista para las compras
        public static List<compras> mostrarComp()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "compras";

            conexion r = new conexion(url, "GET");

            String buy = r.getItem();

            if (buy.Equals("[]"))
            {
                return null;

            }
            else
            {
                buy = buy.Replace("\"cliente\":{", "");
                buy = buy.Replace("}}", "}");

                List<compras> RaquetZoneComp = JsonConvert.DeserializeObject<List<compras>>(buy);

            return RaquetZoneComp;
            }

        }

        //Recoger clientes para compras
        public static List<string> comprasClientes(string cif)
        {
            String url2 = ConfigurationManager.AppSettings["AccesoBD"] + "compras";

            conexion r2 = new conexion(url2, "GET");

            string compa = r2.getItem();

            var matches = Regex.Matches(compa, @"dnicli[\s\S]{0,3}([A-Z0-9]{1,15})[\s\S]");
            List<string> sacarCliente = new List<string>();
            List<string> ListaFinal = new List<string>();
            var sacarCliente1 = matches.Cast<Match>().SelectMany(o => o.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));

            sacarCliente.AddRange(sacarCliente1);

            if(sacarCliente.Count == 0)
            {
                return null;
            }
            else {
            int contador = 0;
            int vacio = 0;

            String urlSE = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + cif + "/clientes";

            conexion r3 = new conexion(urlSE, "GET");

            string SCC = r3.getItem();

            do
            {

                if (SCC.Contains(sacarCliente[contador]))
                {
                    ListaFinal.Add(sacarCliente[contador]);
                    vacio++;
                }
                contador++;
            } while (contador != sacarCliente.Count);
            
            if(vacio == 0)
            {
                return null;
            }
            else
            {
                List<string> ListaSinRepeticiones = ListaFinal.Distinct().ToList();
                return ListaSinRepeticiones;
            }
            }
        }
        

        //Lista para las compras ordenadas por fecha
        public static List<compras> mostrarCompFecha()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "compras/fecha";

            conexion r = new conexion(url, "GET");

            String buyF = r.getItem();

            if (buyF.Equals("[]"))
            {
                return null;

            }
            else
            {
            List<compras> RaquetZoneComp = JsonConvert.DeserializeObject<List<compras>>(buyF);

            return RaquetZoneComp;
            }

        }

        //Lista para las compras ordenadas por fecha
        public static List<producto_compra> mostrarCompProd()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "producto_compras";

            conexion r = new conexion(url, "GET");

            String buyCP = r.getItem();

            if (buyCP.Equals("[]"))
            {
                return null;

            }
            else
            {
                buyCP = buyCP.Replace("\"cliente\":{", "");
                buyCP = buyCP.Replace("\"producto\":{", "");
                buyCP = buyCP.Replace("\"compra\":{", "");
                buyCP = buyCP.Replace("\"empresa\":{", "");
                buyCP = buyCP.Replace("\"id\":{", "");
                buyCP = buyCP.Replace("},", "");
                buyCP = buyCP.Replace("}", "");
                buyCP = buyCP.Replace("\"idprod\":", ",\"idprod\":");
                buyCP = buyCP.Replace("\"idcomp\":", ",\"idcomp\":");
                buyCP = buyCP.Replace("\"cantidadprodcomp\":", ",\"cantidadprodcomp\":");
                buyCP = buyCP.Replace("]", "");
                buyCP = buyCP.Replace("{", "},{");
                buyCP = buyCP.Remove(1, 2);
                buyCP = buyCP + "}]";
                String finalCP = buyCP.Replace(" ", "");


                List<producto_compra> RaquetZoneComp = JsonConvert.DeserializeObject<List<producto_compra>>(finalCP);

                return RaquetZoneComp;
            }

        }

        //Lista para los servicios
        public static List<servicios> mostrarServicio()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "servicios";

            conexion r = new conexion(url, "GET");

            String Serv = r.getItem();

            
            if (Serv.Equals("[]"))
            {
                return null;

            }
            else
            {
            List<servicios> RaquetZoneServ = JsonConvert.DeserializeObject<List<servicios>>(Serv);

            return RaquetZoneServ;
            }

        }

        //Lista para los servicios
        public static List<servicios> mostrarServicioP(string cif)
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + cif + "/servicios";

            conexion r = new conexion(url, "GET");

            String Serv = r.getItem();

            if (Serv.Equals("[]"))
            {
                return null;

            }
            else
            {
                List<servicios> RaquetZoneServ = JsonConvert.DeserializeObject<List<servicios>>(Serv);

                return RaquetZoneServ;
            }

        }

        //Lista para las reservas
        public static List<reservas> mostrarReservas()
        {
            String url = ConfigurationManager.AppSettings["AccesoBD"] + "reservas";

            conexion r = new conexion(url, "GET");

            String Reser = r.getItem();

            if (Reser.Equals("[]"))
            {
                return null;
                
            }
            else
            {
                Reser = Reser.Replace("\"cliente\":{", "");
                Reser = Reser.Replace("\"servicio\":{", "");
                Reser = Reser.Replace("\"empresa\":[{", "");
                Reser = Reser.Replace("\"empresa\":{", "");
                Reser = Reser.Replace("\"usuario\":{", ",");
                Reser = Reser.Replace("},", "");
                Reser = Reser.Replace("}", "");
                Reser = Reser.Replace("\"idserv\":", ",\"idserv\":");
                Reser = Reser.Replace("]", "");
                Reser = Reser.Replace("{", "},{");
                Reser = Reser.Remove(1, 2);
                Reser = Reser + "}]";
                String finalRes = Reser.Replace(" ", "");

                List<reservas> RaquetZoneRes = JsonConvert.DeserializeObject<List<reservas>>(finalRes);

                return RaquetZoneRes;
            }

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

        public static void facturasPDF(string id, string fecha, string nombre, string descuento, string precio, string cliente, string cantidad)
        {

            // string descuento, string total, string precio, string nombre, string cantidad

            precio = precio.Replace(".", ",");
            descuento = descuento.Replace(".", ",");

            float pre = float.Parse(precio);
            float can = float.Parse(cantidad);
            float des = float.Parse(descuento);
            float tot = 0;
            string predes = "";

            if (des != 0)
            {
                tot = (des / 100 * pre) * can;
            }
            else
            {
                tot = pre * can;
            }

            string total = tot.ToString();
             predes = tot.ToString();


            Document doc = new Document("Factura.docx");
            doc.Range.Replace("$nombre", nombre, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$fecha", fecha, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$descuento", descuento, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$precio", precio, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$total", total, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$id", id, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$cantidad", cantidad, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$cliente", cliente, new FindReplaceOptions(FindReplaceDirection.Forward));
            doc.Range.Replace("$predes", predes, new FindReplaceOptions(FindReplaceDirection.Forward));

            string nombreFac = "Factura" + id + ".pdf";

            string basePath = Application.StartupPath;
            string relativePath = nombreFac;
            string relativePath1 = @"Facturas\" + nombreFac;

            string fullPath = Path.Combine(basePath, relativePath);
            string fullPath1 = Path.Combine(basePath, relativePath1);

            string rutaMala = fullPath;
            string rutaBuena = fullPath1;

            //Comprobamos primero que no existe el archivo antes de crearlo

            string relativePath2 = @"Facturas";

            string fullPath2 = Path.Combine(basePath, relativePath2);

            DirectoryInfo di = new DirectoryInfo(fullPath2);
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
