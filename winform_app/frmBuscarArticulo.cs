using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBuscarArticulo_Load(object sender, EventArgs e)
        {
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Precio");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if (cbCampo.SelectedItem == null || cbCriterio.SelectedItem == null)
            {
                MessageBox.Show("por favor completar las casillas");
                return;
            }
            if (cbCampo.SelectedItem.ToString() == "Precio" && txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor cargar un precio");
                return;
            }
            try
            {                
             string campo = cbCampo.SelectedItem.ToString();
             string criterio = cbCriterio.SelectedItem.ToString();             
             string Buscar = txtPrecio.Text;             
             dgvBuscarArt.DataSource = negocio.Listar(campo, criterio, Buscar);
             dgvBuscarArt.Columns["IndiceImagen"].Visible = false;
             dgvBuscarArt.Columns["IndiceImagen"].Visible = false;
             dgvBuscarArt.Columns["Id"].Visible = false;
             dgvBuscarArt.Columns["Id"].Visible = false;
                

            }
            catch (Exception)
            {
                MessageBox.Show("Por favor cargar un precio");
            }
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCriterio.Items.Clear();
            if (cbCampo.SelectedItem.ToString() == "Precio")
            {
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
            }
            else
            {
                cbCriterio.Items.Add("Contiene");
                cbCriterio.Items.Add("Empieza con");
            }
        }
    }
}
