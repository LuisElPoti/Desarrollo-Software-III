using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demouno
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Estado { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public decimal Balance { get; set; }
        public string Comentario { get; set; }

    }
}
