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
    public partial class frmAdministrarArticulo : Form
    {
        private Articulo seleccionado = null;
        private List<Articulo> listaArticulo;


        public frmAdministrarArticulo()
        {
            InitializeComponent();
        }



        private void emprolijarDgv()
        {
            dgvArticulos.Columns["IndiceImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }


        private void cargarImagen(Imagen imagen)
        {
            try
            {
                pbxImagen.Load(imagen.Url);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://mcfil.net.ar/wp-content/uploads/2021/04/no-dispnible.jpg");
            }
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                cargarImagen(seleccionado.ListaImagenes[0]);
            }
        }


        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                emprolijarDgv();
                cargarImagen(listaArticulo[0].ListaImagenes[0]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenes = new ImagenNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    imagenes.eliminarImagenIdArticulo(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAdministrarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }




        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                List<Imagen> lista = new List<Imagen>();
                lista = seleccionado.ListaImagenes;
                int maximo = lista.Count;

                if (seleccionado.IndiceImagen < maximo - 1)
                    seleccionado.IndiceImagen++;
                else if (seleccionado.IndiceImagen == maximo - 1)
                    seleccionado.IndiceImagen = 0;

                cargarImagen(lista[seleccionado.IndiceImagen]);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            List<Imagen> lista = new List<Imagen>();
            lista = seleccionado.ListaImagenes;
            int maximo = lista.Count;

            if (seleccionado.IndiceImagen == 0)
                seleccionado.IndiceImagen = maximo - 1;
            else
                seleccionado.IndiceImagen--;

            cargarImagen(lista[seleccionado.IndiceImagen]);
        }

        private void dgvArticulos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                if (seleccionado.ListaImagenes != null && seleccionado.ListaImagenes.Count > 0)
                {
                    // Reiniciar el índice de la imagen para el nuevo artículo
                    seleccionado.IndiceImagen = 0;

                    // Cargar la primera imagen de la lista
                    cargarImagen(seleccionado.ListaImagenes[0]);
                }
                else
                {
                    // Si no hay imágenes, cargar una imagen por defecto
                    cargarImagen(new Imagen { Url = "https://mcfil.net.ar/wp-content/uploads/2021/04/no-dispnible.jpg" });
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarArticulo editarArticulo = new frmEditarArticulo(seleccionado);
            editarArticulo.ShowDialog();
            cargar();
        }
    }
}


