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
    public partial class EditarMedicamento : System.Web.UI.Page
    {
        static List<Medicamento> enfermedadTemp = new List<Medicamento>();
        static List<Medicamento> medicamentos = new List<Medicamento>();
        static List<ListaPacientes> guardarMedicamentos = new List<ListaPacientes>();
        static string encontarMedicamento;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarMedicamentos();
        }

        protected void CargarMedicamentos()
        {
            string archivo = Server.MapPath("Medicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            guardarMedicamentos = JsonConvert.DeserializeObject<List<ListaPacientes>>(json);
        }

        protected void GuardarMedicamento()
        {
            string json = JsonConvert.SerializeObject(guardarMedicamentos);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void ButtonBuscarMedicamento_Click(object sender, EventArgs e)
        {
            encontarMedicamento = TextBoxIDMedicamento.Text;
            bool encontrado = false;

            foreach(var u in guardarMedicamentos)
            {
                Medicamento encontrarMedicina = u.listaMedicamientos.Find(c => c.codigoMedicamento == encontarMedicamento);
                if(encontrarMedicina != null)
                {
                    TextBoxIngredienteMedicamento.Text = encontrarMedicina.codigoMedicamento;
                    TextBoxMarcaComercial.Text = encontrarMedicina.marcaComercial;
                    encontrado = true;

                }
            }
            if(!encontrado)
            {
                Response.Write("<script>alert('Medicina no encontrada o no Registrada')</script>");
                TextBoxIngredienteMedicamento.Text = "";
                TextBoxMarcaComercial.Text = "";
                TextBoxIDMedicamento.Text = "";

            }
        }

        

        protected void ButtonGuardarCambios_Click(object sender, EventArgs e)
        {
            
            foreach(var u in guardarMedicamentos)
            {
                int editarMedicamento = u.listaMedicamientos.FindIndex(c => c.codigoMedicamento == encontarMedicamento);
                if(editarMedicamento > -1)
                {
                    u.listaMedicamientos[editarMedicamento].ingredienteGenerico = TextBoxIngredienteMedicamento.Text;
                    u.listaMedicamientos[editarMedicamento].marcaComercial = TextBoxMarcaComercial.Text;
                }
            }
            GuardarMedicamento();
            Response.Write("<script>alert('Datos de Paciente Guardados Correctamente')</script>");
            TextBoxIngredienteMedicamento.Text = "";
            TextBoxMarcaComercial.Text = "";
            TextBoxIDMedicamento.Text = "";
        }
    }
}