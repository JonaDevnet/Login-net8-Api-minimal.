using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int idUser { get; set; }
        public string Nombre { get; set; } = null!;
        public string Pass { get; set; } = null!;
    }
}
