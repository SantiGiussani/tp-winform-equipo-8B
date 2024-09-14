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
    public partial class frmBuscarArticulo : Form
    {
        public frmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PbImagen.Load(imagen);
            }
            catch (Exception)
            {
                PbImagen.Load("https://mcfil.net.ar/wp-content/uploads/2021/04/no-dispnible.jpg");
            }
        }

        private void txtBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaFiltrada;
            ArticuloNegocio Negocio = new ArticuloNegocio();
            ListaFiltrada = Negocio.listar();
            string text = txtBoxFiltro.Text;

            if (text != "")
            {
                ListaFiltrada = ListaFiltrada.FindAll(x => x.Nombre.ToLower().Contains(text.ToLower()) || x.Descripcion.ToLower().Contains(text.ToLower()) || x.Codigo.ToLower().Contains(text.ToLower()));
            }


            dgvBuscarArt.DataSource = null;
            dgvBuscarArt.DataSource = ListaFiltrada;
            dgvBuscarArt.Columns["IndiceImagen"].Visible = false;
            dgvBuscarArt.Columns["Id"].Visible = false;
        }

        private void dgvBuscarArt_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvBuscarArt.CurrentRow != null)
            {
                PbImagen.Visible = true;
                btnImagenDer.Visible = true;
                btnImagenIzq.Visible = true;
                lblCantImagen.Visible = true;
                Articulo seleccionado = (Articulo)dgvBuscarArt.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                cargarImagen(seleccionado.ListaImagenes[0].Url);
                configEtiquetaImg(seleccionado);
            }
            else
            {
                PbImagen.Visible = false;
                btnImagenDer.Visible = false;
                btnImagenIzq.Visible = false;
                lblCantImagen.Visible = false;
            }
        }

        private void configEtiquetaImg(Articulo seleccionado)
        {
            seleccionado = (Articulo)dgvBuscarArt.CurrentRow.DataBoundItem;
            int cantImagenes = seleccionado.ListaImagenes.Count;
            int imgActual = seleccionado.IndiceImagen + 1;
            lblCantImagen.Text = imgActual + "/" + cantImagenes;

            //POSICIÓN ETIQUETA
            int btnIzquierdo = btnImagenIzq.Location.X;
            int btnDerecho = btnImagenDer.Location.X + btnImagenDer.Width;
            int posicionCentrada = (btnDerecho + btnIzquierdo) / 2;
            lblCantImagen.Location = new Point(posicionCentrada - (lblCantImagen.Width / 2), lblCantImagen.Location.Y);
        }

        private void btnImagenIzq_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBuscarArt.CurrentRow.DataBoundItem;

            int maximo = seleccionado.ListaImagenes.Count;

            if (seleccionado.IndiceImagen == 0)
                seleccionado.IndiceImagen = maximo - 1;
            else
                seleccionado.IndiceImagen--;

            string imagen = seleccionado.ListaImagenes[seleccionado.IndiceImagen].Url;
            cargarImagen(imagen);
            configEtiquetaImg(seleccionado);
        }

        private void btnImagenDer_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBuscarArt.CurrentRow.DataBoundItem;

            int maximo = seleccionado.ListaImagenes.Count;

            if (seleccionado.IndiceImagen == maximo - 1)
                seleccionado.IndiceImagen = 0;
            else
                seleccionado.IndiceImagen++;

            string imagen = seleccionado.ListaImagenes[seleccionado.IndiceImagen].Url;
            cargarImagen(imagen);
            configEtiquetaImg(seleccionado);
        }
    }
}
