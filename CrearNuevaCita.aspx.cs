using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Progra
{
    public partial class Contact : Page
    {        
        static List<ListaPacientes> Listadopacientes = new List<ListaPacientes>();
        static List<ListaPacientes> ListadoAgenda = new List<ListaPacientes>();
        static List<Agenda> agendaTemp = new List<Agenda>();
        static string encontrarDpi;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
            BloquearDatosPersonales();

        }

        protected void CargarDatos()
        {
            string archivo = Server.MapPath("Pacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Listadopacientes = JsonConvert.DeserializeObject<List<ListaPacientes>>(json);
        }
        protected void GuardarNuevaCita()
        {
            string json = JsonConvert.SerializeObject(ListadoAgenda);
            string archivo = Server.MapPath("Citas.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void BloquearDatosPersonales()
        {
            TextBoxNombre.Enabled = false;
            TextBoxApellido.Enabled = false;
            TextBoxTelefono.Enabled = false;
        }
       
        protected void ButtonBuscarPaciente_Click(object sender, EventArgs e)
        {
            encontrarDpi = TextBoxBuscarDPI.Text;
            bool encontrado = false;

            foreach (var u in Listadopacientes)
            {
                Paciente buscarpaciente = u.listadoPacientes.Find(c => c.DPI == encontrarDpi);
                if(buscarpaciente != null)
                {
                    
                    TextBoxNombre.Text = buscarpaciente.nombre;
                    TextBoxApellido.Text = buscarpaciente.apellido;
                    TextBoxTelefono.Text = buscarpaciente.telefono;                   
                    encontrado = true;
                }
            }
            if(!encontrado)
            {
                Response.Write("<script>alert('Paciente no Encontrado o No Resgistrado')</script>");
                TextBoxNombre.Text = "";
                TextBoxApellido.Text = "";
                TextBoxTelefono.Text = "";
            }
               

        }

        protected void ButtonGuardarCita_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            ListaPacientes GuardarAgenda = new ListaPacientes();
            agenda.DPIPaciente = TextBoxBuscarDPI.Text;
            agenda.fecha = CalendarFechaCita.SelectedDate;
            agenda.horaInicio = DropDownHoraInicio.SelectedItem.ToString();
            agenda.horaFin = DropDownHoraFin.SelectedItem.ToString();
            agendaTemp.Add(agenda);        
            GuardarAgenda.listaAgenda = agendaTemp.ToArray().ToList();
            ListadoAgenda.Add(GuardarAgenda);
            GuardarNuevaCita();

            TextBoxBuscarDPI.Text = "";
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxTelefono.Text = "";

        }
    }
}