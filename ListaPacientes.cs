using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Progra
{
    public class ListaPacientes
    {
        public List<Paciente> listadoPacientes { get; set; }
        public List<Agenda> listaAgenda { get; set; }
        public List<Medicamento> listaMedicamientos { get; set; }
    }
}