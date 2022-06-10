using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Progra
{
    public class Paciente
    {
      
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string DPI { get; set; }
        public string dirreccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string telefono { get; set; }
    }
}