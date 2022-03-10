using Factura.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace Factura
{
    public partial class GenerarFactura : Form
    {
        public GenerarFactura()
        {
            InitializeComponent();
        }

        private void GenerarFactura_Load(object sender, EventArgs e)
        {
            List<Models.ViewModels.SuscriptoresViewModel> lstSuscriptores = new List<Models.ViewModels.SuscriptoresViewModel>();

            using (Models.facturaEntities db = new Models.facturaEntities())
            {
                // consulta a BD LINQ
                lstSuscriptores = (from d in db.suscriptores
                                   select new Models.ViewModels.SuscriptoresViewModel
                                   {
                                       Id = d.id,
                                       Nombre = d.nombre_completo,
                                       Barrio = d.barrio,
                                       Estrato = d.id_estrato,
                                       Direccion = d.direccion,
                                       Consumo = d.consumo,

                                   }).ToList();


            }

            cbSeleccionar.DataSource = lstSuscriptores;
            cbSeleccionar.ValueMember = "Id";
            cbSeleccionar.DisplayMember = "Nombre";

        }


        public string layoutHtml;
        string namePDf = DateTime.Now.ToString("ddyyyyMmss");

        private void cbSeleccionar_SelectedValueChanged(object sender, EventArgs e)
        {

            try {
                List<Models.ViewModels.SuscriptoresViewModel> lstSuscriptores = new List<Models.ViewModels.SuscriptoresViewModel>();
                int IdSeleccionado = (int)cbSeleccionar.SelectedValue;
                using (Models.facturaEntities db = new Models.facturaEntities())
                {
                    // consulta a BD LINQ
                    lstSuscriptores = (from d in db.suscriptores
                                       where d.id == IdSeleccionado
                                       select new Models.ViewModels.SuscriptoresViewModel
                                       {
                                           Id = d.id,
                                           Nombre = d.nombre_completo,
                                           Barrio = d.barrio,
                                           Estrato = d.id_estrato,
                                           Direccion = d.direccion,
                                           Consumo = d.consumo,

                                       }).ToList();


                }

                foreach (var suscriptor in lstSuscriptores)
                {
                    txtBarrio.Text = suscriptor.Barrio;
                    txtConsumo.Text = suscriptor.Consumo.ToString();
                    txtDireccion.Text = suscriptor.Direccion;
                    txtEstrato.Text = suscriptor.Estrato.ToString();

                    EstratosViewModel servicios = new EstratosViewModel();
                    servicios.DefinirTarifas(suscriptor.Estrato);

                    servicios.ConsumoTotal(suscriptor.Consumo);

                    txtSubtotalAlcantarillado.Text = servicios.SubTotalAlcantarillado.ToString("C");
                    txtSubTotalAcueducto.Text = servicios.SubTotalAgua.ToString("C");
                    txtAseo.Text = servicios.TarifaAseo.ToString("C");
                    txtValoPagar.Text = servicios.TotalaPagar.ToString("C");

                    // obtener día
                    var obtenerDia = DateTime.Now.Day;
                    var diaSugerido = obtenerDia + 10;

                    layoutHtml = Properties.Resources.template.ToString();

                    layoutHtml = layoutHtml.Replace("@CONTRATO", namePDf);
                    layoutHtml = layoutHtml.Replace("@REFERENCIA", DateTime.Now.ToString("ddyyyyss"));
                    layoutHtml = layoutHtml.Replace("@NOMBRE", suscriptor.Nombre);
                    layoutHtml = layoutHtml.Replace("@ESTRATO", suscriptor.Estrato.ToString());
                    layoutHtml = layoutHtml.Replace("@BARRIO", suscriptor.Barrio);
                    layoutHtml = layoutHtml.Replace("@DIRECCION", suscriptor.Direccion);
                    layoutHtml = layoutHtml.Replace("@FECHA", DateTime.Now.ToString("MMMM") + " " +  diaSugerido + " " + "del " + DateTime.Now.ToString("yyyy"));
                    layoutHtml = layoutHtml.Replace("@CONSUMO", suscriptor.Consumo.ToString());
                    layoutHtml = layoutHtml.Replace("@SUBTOTALACUEDUCTO", servicios.SubTotalAgua.ToString("C"));
                    layoutHtml = layoutHtml.Replace("@SUBTOTALALCANTARILLADO", servicios.SubTotalAlcantarillado.ToString("C"));
                    layoutHtml = layoutHtml.Replace("@SUBTOTALASEO", servicios.SubTotalAgua.ToString("C"));
                    layoutHtml = layoutHtml.Replace("@TOTALAPAGAR", servicios.TotalaPagar.ToString("C"));


                }

            } catch(InvalidCastException ex)
            {
                // 
            }

          

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = namePDf + ".pdf";
            //save.ShowDialog();

            

            if (save.ShowDialog() == DialogResult.OK )
            {
                using( FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                     Document pdf = new Document(PageSize.A4, 20, 20, 20, 20);

                    PdfWriter writer = PdfWriter.GetInstance(pdf, stream);


                    pdf.Open();

                    pdf.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoWater, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdf.LeftMargin, pdf.Top - 50);
                    pdf.Add(img);

                    // leer plantilla personalizada
                    using ( StringReader sr = new StringReader(layoutHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);
                    }

                    pdf.Close();

                    stream.Close(); 

                }


            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
