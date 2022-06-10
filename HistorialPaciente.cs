using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Progra
{
    public class HistorialPaciente
    {
        public string IdConsulta { get; set; }
        public string nitPaciente { get; set; }
        public DateTime fechaHistorial { get; set; }
        public string horaHistorial { get; set; }
        public List<SintomaReceta> SintomasyRecetas { get; set;}
        public string diagnostico { get; set; }
        public string tratamiento { get; set; }
        public DateTime proximaVisita { get; set; }
        public string costoConsulta { get; set; }
              
    }
}