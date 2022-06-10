using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Progra
{
    public partial class _Default : Page
    {
        static List<Paciente> pacientesTemp = new List<Paciente>();
        static List<ListaPacientes> Listadopacientes = new List<ListaPacientes>();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Limpiar()
        {
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxDPI.Text = "";
            TextBoxDireccion.Text = "";
            CalendarFechaNaci.Controls.Clear();
            TextBoxTelefono.Text = "";

        }
        protected void GuardarPaciente()
        {
            string json = JsonConvert.SerializeObject(Listadopacientes);            
            string archivo = Server.MapPath("Pacientes.json");          
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonAgregarPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            ListaPacientes Guardarpaciente = new ListaPacientes();
            paciente.nombre = TextBoxNombre.Text;
            paciente.apellido = TextBoxApellido.Text;
            paciente.DPI = TextBoxDPI.Text;
            paciente.dirreccion = TextBoxDireccion.Text;
            paciente.FechaNacimiento = CalendarFechaNaci.SelectedDate;
            paciente.telefono = TextBoxTelefono.Text;
            pacientesTemp.Add(paciente);
            Guardarpaciente.listadoPacientes = pacientesTemp.ToArray().ToList();
            Listadopacientes.Add(Guardarpaciente);
            GuardarPaciente();
            Limpiar();
        }

        
    }
}