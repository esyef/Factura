using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Models.ViewModels
{
    internal class SuscriptoresViewModel
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Consumo { get; set; }
        public string Barrio { get; set; }
        public int Estrato { get; set; }
    }
}
