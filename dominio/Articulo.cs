using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {   
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public string ImagenURL { get; set; }
        public decimal Precio { get; set; }
    }
}
