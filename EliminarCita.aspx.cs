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
    public partial class EliminarCita : System.Web.UI.Page
    {       
        static List<ListaPacientes> ListadoAgenda = new List<ListaPacientes>();
        static string encontrarDPI;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
            BloquearDatos();
        }
        protected void CargarDatos()
        {
            string archivo = Server.MapPath("Citas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            ListadoAgenda = JsonConvert.DeserializeObject<List<ListaPacientes>>(json);
        }
        protected void BloquearDatos()
        {
            TextBoxFechaCita.Enabled = false;
            TextBoxHoraInicio.Enabled = false;
            TextBoxHoraFin.Enabled = false;
        }
        protected void ButtonEncontrar_Click(object sender, EventArgs e)
        {
            encontrarDPI = TextBoxEnocntrarDPI.Text;
            bool encontrado = false;

            foreach(var u in ListadoAgenda)
            {
                Agenda encontrarCita = u.listaAgenda.Find(c => c.DPIPaciente == encontrarDPI);

                if(encontrarCita != null)
                {
                    TextBoxFechaCita.Text = Convert.ToString(encontrarCita.fecha);
                    TextBoxHoraInicio.Text = encontrarCita.horaInicio;
                    TextBoxHoraFin.Text = encontrarCita.horaFin;                   
                    encontrado = true;
                }
            }
            if(!encontrado)
            {
                Response.Write("<script>alert('Cita no encontrada o no fue creada)</script>");
                TextBoxFechaCita.Text = "";
                TextBoxHoraInicio.Text = "";
                TextBoxHoraFin.Text = "";
                TextBoxEnocntrarDPI.Text = "";
            }

        }
        protected void GuardarCambios()
        {
            string json = JsonConvert.SerializeObject(ListadoAgenda);
            string archivo = Server.MapPath("Citas.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void ButtonBorrarCita_Click(object sender, EventArgs e)
        {
            encontrarDPI = TextBoxEnocntrarDPI.Text;
            foreach(var u in ListadoAgenda)
            {
                Agenda BorrarCita = u.listaAgenda.Find(c => c.DPIPaciente == encontrarDPI);
                if(BorrarCita != null)
                {
                    u.listaAgenda.Remove(BorrarCita);
                }
            }
            GuardarCambios();
            TextBoxFechaCita.Text = "";
            TextBoxHoraInicio.Text = "";
            TextBoxHoraFin.Text = "";
            TextBoxEnocntrarDPI.Text = "";
        }
    }
}