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
    public partial class About : Page
    {       
        static List<ListaPacientes> Listadopacientes = new List<ListaPacientes>();
        static string encontrarDpi;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void CargarDatos()
        {
            string archivo = Server.MapPath("Pacientes.json");           
            StreamReader jsonStream = File.OpenText(archivo);           
            string json = jsonStream.ReadToEnd();          
            jsonStream.Close();           
            Listadopacientes = JsonConvert.DeserializeObject<List<ListaPacientes>>(json);
        }
        protected void GuardarNuevoPaciente()
        {
            string json = JsonConvert.SerializeObject(Listadopacientes);
            string archivo = Server.MapPath("Pacientes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            foreach(var a in Listadopacientes)
            {
                int editarPaciente = a.listadoPacientes.FindIndex(c => c.DPI == encontrarDpi);

                if (editarPaciente > -1)
                {
                    a.listadoPacientes[editarPaciente].nombre = TextBoxEditarNombre.Text;
                    a.listadoPacientes[editarPaciente].apellido = TextBoxEditarApellido.Text;
                    a.listadoPacientes[editarPaciente].dirreccion = TextBoxEditarDireccion.Text;
                    a.listadoPacientes[editarPaciente].FechaNacimiento = CalendarFechaNaci.SelectedDate;
                    a.listadoPacientes[editarPaciente].telefono = TextBoxEditarTelefono.Text;
                                    
                }
            }
            GuardarNuevoPaciente();
            Response.Write("<script>alert('Datos de Paciente Guardados Correctamente')</script>");
            TextBoxEditarNombre.Text = "";
            TextBoxEditarApellido.Text = "";
            TextBoxEditarDireccion.Text = "";
            TextBoxEditarFechaNaci.Text = "";
            TextBoxEditarTelefono.Text = "";
        }


        protected void ButtonBuscarPaciente_Click(object sender, EventArgs e)
        {
            encontrarDpi = TextBoxEditarDPI.Text;
            bool encontrado = false;

            foreach (var u in Listadopacientes)
            {
                Paciente buscarPaciente = u.listadoPacientes.Find(c => c.DPI == encontrarDpi);
                if(buscarPaciente != null)
                {
                    TextBoxEditarNombre.Text = buscarPaciente.nombre;
                    TextBoxEditarApellido.Text = buscarPaciente.apellido;
                    TextBoxEditarDireccion.Text = buscarPaciente.dirreccion;
                    TextBoxEditarFechaNaci.Text = Convert.ToString(buscarPaciente.FechaNacimiento);
                    TextBoxEditarTelefono.Text = buscarPaciente.telefono;
                    encontrado = true;  
                }
            }
            if(!encontrado)
            {
                Response.Write("<script>alert('Paciente no Encontrado o No Resgistrado')</script>");
                TextBoxEditarNombre.Text = "";
                TextBoxEditarApellido.Text = "";
                TextBoxEditarDireccion.Text = "";
                TextBoxEditarFechaNaci.Text = "";
                TextBoxEditarTelefono.Text = "";
            }

        }
    }
}


