using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;



namespace winform_app
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articuloAux = new Articulo();
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }






        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenArt.Load(imagen);
            }
            catch
            {
                pbImagenArt.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }



        private void btAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            if (!negocio.existeCodigo(tbCodArt.Text))
            {
                if (!string.IsNullOrWhiteSpace(tbURLImagen.Text))
                {
                    try
                    {
                        // cargar datos en articuloAux
                        articuloAux.Precio = decimal.Parse(tbPrecio.Text);
                        articuloAux.Nombre = tbNombre.Text;
                        articuloAux.Descripcion = tbDescripcion.Text;
                        articuloAux.Codigo = tbCodArt.Text;
                        articuloAux.Marca_ = (Marca)cbMarca.SelectedItem;
                        articuloAux.Categoria_ = (Categoria)cbCategoria.SelectedItem;

                        // agregar a db
                        negocio.agregar(articuloAux);

                        // obtener id del codigo
                        var nuevoArticulo = negocio.listar().FirstOrDefault();
                        if (nuevoArticulo != null)
                        {
                            // Agregar imagen al articuloAux
                            Imagen imagen = new Imagen
                            {
                                Id = nuevoArticulo.Id,
                                Url = tbURLImagen.Text // URL ingresada en el TextBox
                            };
                            imagenNegocio.agregarImagen(imagen);
                        }

                        MessageBox.Show("Articulo agregado exitosamente.");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en el artículo, por favor verifique.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todo articulo debe poseer una imagen,por favor ingrese una URL valida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un codigo diferente.");
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

        private void btCancelar_Click(object sender, EventArgs e)
        {      
            DialogResult resultado = MessageBox.Show("¿Esta seguro de que desea salir?", "Confirmacion de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            { 
                this.Close();
            }
        }

        private void tbURLImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(tbURLImagen.Text);
        }
    }
}
