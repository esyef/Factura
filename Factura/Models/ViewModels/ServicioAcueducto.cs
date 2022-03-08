using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Models.ViewModels
{
    public class ServicioAcueducto
    {
        
        public int CantidadConsuno { get; set; }
        public decimal TotalConsumo { get; set; }

   

        public void GetConsumo(int cantidadConsumo)
        {
                this.CantidadConsuno = cantidadConsumo;
        }



    }
}
