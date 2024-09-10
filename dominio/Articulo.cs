using System;
using System.Collections.Generic;
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
        public string Descripcion { get; set; }
        public Clasificacion Marca { get; set; }
        public Clasificacion categoria { get; set; }  
        public decimal precio { get; set; }
        public List<Imagen> ListaImagenes { get; set; } = new List<Imagen>(); //Se inicializa la lista junto con el objeto

    }
}
