using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;



namespace winform_app
{
    public partial class frmAgregarArticulo : Form
    {
        
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                // cargar
                art.Precio = decimal.Parse(tbPrecio.Text);
                art.Nombre = tbNombre.Text;
                art.Descripcion = tbDescripcion.Text;
                art.Codigo = tbCodArt.Text;
                art.Marca_ = (Marca)cbMarca.SelectedItem;
                art.Categoria_ = (Categoria)cbCategoria.SelectedItem;

                // agregar a db
                negocio.agregar(art);

                // obtener id del codigo
                var nuevoArticulo = negocio.listarXcodigo(art.Codigo).FirstOrDefault();
                if (nuevoArticulo != null)
                {
                    // Agregar imagen al art
                    Imagen imagen = new Imagen
                    {
                        Id = nuevoArticulo.Id,
                        Url = tbURLImagen.Text // URL ingresada en el TextBox
                    };
                    imagenNegocio.agregarImagen(imagen);
                }

                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNeg = new CategoriaNegocio();
            MarcaNegocio marNeg = new MarcaNegocio();

            try
            {
                cbMarca.DataSource = marNeg.listar();
                cbCategoria.DataSource = catNeg.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }
    }
}
