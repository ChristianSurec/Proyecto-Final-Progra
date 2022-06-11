using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Progra
{
    public partial class AgregarMedicamiento : System.Web.UI.Page
    {
        static List<Medicamento> enfermedadTemp = new List<Medicamento>();
        static List<Medicamento> medicamentos = new List<Medicamento>();
        static List<ListaPacientes> guardarMedicamentos = new List<ListaPacientes>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void GuardarMedicamento()
        {
            string json = JsonConvert.SerializeObject(guardarMedicamentos);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
            ListaPacientes listaMedicamento = new ListaPacientes();
            medicamento.codigoMedicamento = TextBoxIDMedicamento.Text;
            medicamento.ingredienteGenerico = TextBoxIngredienteMedicamento.Text;
            medicamento.marcaComercial = TextBoxMarcaComercial.Text;
            medicamento.enfermedades= enfermedadTemp.ToArray().ToList();
            medicamentos.Add(medicamento);

            listaMedicamento.listaMedicamientos = medicamentos.ToArray().ToList();
            guardarMedicamentos.Add(listaMedicamento);
            GuardarMedicamento();

        }

        protected void ButtonAgregarTemp_Click(object sender, EventArgs e)
        {
            Medicamento enfermedad = new Medicamento();           
            enfermedad.enfermedadesAplica = TextBoxListadoEnfermedadTemp.Text;
            enfermedadTemp.Add(enfermedad);

            GridViewListadoEnfermedades.DataSource = enfermedadTemp;
            GridViewListadoEnfermedades.DataBind();
        }
    }
}