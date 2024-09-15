using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmEditarArticulo : Form
    {
        private Articulo articuloAux = null;
        private int indexSeleccionado = -1;

        public frmEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            articuloAux = articulo;
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNeg = new CategoriaNegocio();
            MarcaNegocio marNeg = new MarcaNegocio();

            tbCodArt.Text = articuloAux.Codigo;
            tbNombre.Text = articuloAux.Nombre;
            tbDescripcion.Text = articuloAux.Descripcion;

            if (articuloAux.ListaImagenes != null && articuloAux.ListaImagenes.Count > 0)
            {
                cbUrlImagenes.DataSource = articuloAux.ListaImagenes;
                cbUrlImagenes.DisplayMember = "Url";
                cbUrlImagenes.ValueMember = "Url";
                cargarImagen(articuloAux.ListaImagenes[0].Url);
            }
            else
            {
                cbUrlImagenes.Items.Clear();
                pbImagenArt.Image = null;
            }

            cbMarca.DataSource = marNeg.listar();
            cbCategoria.DataSource = catNeg.listar();
            tbPrecio.Text = articuloAux.Precio.ToString();
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

        private void ActualizarComboBoxImagenes()
        {
            cbUrlImagenes.DataSource = null;
            cbUrlImagenes.DataSource = articuloAux.ListaImagenes;
            cbUrlImagenes.DisplayMember = "Url";
            cbUrlImagenes.ValueMember = "Url";
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string nuevaUrl = tbAgregarImagen.Text;

            if (!string.IsNullOrEmpty(nuevaUrl))
            {
                // Verificar si la URL ya existe
                if (articuloAux.ListaImagenes.Any(img => img.Url == nuevaUrl))
                {
                    MessageBox.Show("Esta URL ya está en la lista de imagenes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Imagen nuevaImagen = new Imagen { Url = nuevaUrl };
                    articuloAux.ListaImagenes.Add(nuevaImagen);
                    ActualizarComboBoxImagenes();
                    cbUrlImagenes.SelectedItem = nuevaImagen;
                    cargarImagen(nuevaImagen.Url);
                    MessageBox.Show("Imagen agregada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una URL valida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (articuloAux.ListaImagenes != null && articuloAux.ListaImagenes.Count > 0 && cbUrlImagenes.SelectedIndex >= 0)
                {
                    string urlAEliminar = cbUrlImagenes.SelectedValue.ToString();

                    DialogResult confirmacion = MessageBox.Show("¿Esta seguro de que desea eliminar la imagen seleccionada?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        articuloAux.ListaImagenes.RemoveAll(img => img.Url == urlAEliminar);
                        MessageBox.Show("Imagen eliminada con éxito.");
                        ActualizarComboBoxImagenes();

                        if (articuloAux.ListaImagenes.Count > 0)
                        {
                            cargarImagen(articuloAux.ListaImagenes[0].Url);
                        }
                        else
                        {
                            pbImagenArt.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imágenes para eliminar o no se ha seleccionado una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUrlImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexSeleccionado = cbUrlImagenes.SelectedIndex;
            cargarImagen(cbUrlImagenes.Text);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.modificar(articuloAux);
            negocio.actualizarImagenes(articuloAux);
            MessageBox.Show("Articulo modificado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
