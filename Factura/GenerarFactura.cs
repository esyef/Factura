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
                    txtValoPagar.Text = servicios.TotalaPagar.ToString("C");

                }

            } catch(InvalidCastException ex)
            {

            }

          

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }
    }
}
