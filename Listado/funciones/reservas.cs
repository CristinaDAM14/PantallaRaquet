using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaquetZone.funciones
{
    public class reservas
    {
        public int idRes { get; set; }
        public int numPista { get; set; }
        public string fechaRes { get; set; }
        public string horaRes { get; set; }
        public string dnicli { get; set; }
        public string nombrecli { get; set; }
        public string passwordcli { get; set; }
        public int numhorascli { get; set; }
        public string telefonocli { get; set; }
        public string emailcli { get; set; }
        public long idserv { get; set; }
        public string descripcionserv { get; set; }
        public int unidadestiemposerv { get; set; }
        public double precioserv { get; set; }
        public double ivaserv { get; set; }
        public double descuentoserv { get; set; }

    }
}
