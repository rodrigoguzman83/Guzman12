using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Guzman
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Marca> Marcas { get; set; }
        public List<Categoria> Categorias { get; set; }
        public string Imagen { get; set; }
        public float Precio { get; set; }
        public List<Proveedor>Proveedores { get; set; }
    }
}
