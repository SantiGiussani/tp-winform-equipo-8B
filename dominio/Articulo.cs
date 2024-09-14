using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Marca")]
        public Marca Marca_ { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria_ { get; set; }  
        public decimal Precio { get; set; }
        public List<Imagen> ListaImagenes { get; set; } = new List<Imagen>(); //Se inicializa la lista junto con el objeto
        public int IndiceImagen { get; set; }

        public Articulo()
        {
            IndiceImagen = 0;
        }
    }
}
