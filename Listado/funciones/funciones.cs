using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RaquetZone.funciones
{

    public class funciones
    {
        //Lista para los usuarios
        public static List<usuario> mostrarUsr()
        {

            String url = "http://localhost:8081/usuarios";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String persona = r.getItem();

            List<usuario> RaquetZoneUsr = JsonConvert.DeserializeObject<List<usuario>>(persona);

            return RaquetZoneUsr;

        }

        //Lista para las empresas
        public static List<empresa> mostrarEmp()
        {
            String url = "http://localhost:8081/empresa";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            String persona = r.getItem();

            List<empresa> RaquetZoneEmp = JsonConvert.DeserializeObject<List<empresa>>(persona);

            return RaquetZoneEmp;

        }

        //Accesos directos
        
    }
}
