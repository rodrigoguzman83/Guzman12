using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Guzman
{
    public class Proveedor:Persona
    {
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string CP { get; set; }
    }
}
