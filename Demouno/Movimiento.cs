using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demouno
{
    internal class Movimiento
    {
        public int id;
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public decimal Monto { get; set; }
        public string DbCr { get; set; }
        public int TipoTransaccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaTransaccion { get; set; }
    }
}
