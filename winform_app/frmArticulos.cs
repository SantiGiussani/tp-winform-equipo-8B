using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        //CARGA FORMULARIO
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            frmArticulos frmArticulos;
            frmArticulos = this;
        }

        //CAMBIO EN LA SELECCION DEL DGV
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                configEtiquetaImg(seleccionado);
                cargarImagen(seleccionado.ListaImagenes[0].Url);
            }   
        }

        //BOTONES
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null && dgvArticulos.Rows.Count > 0)
            {
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            int maximo = seleccionado.ListaImagenes.Count;

            if (seleccionado.IndiceImagen == 0)
                seleccionado.IndiceImagen = maximo - 1;
            else
                seleccionado.IndiceImagen--;

            string imagen = seleccionado.ListaImagenes[seleccionado.IndiceImagen].Url;
            configEtiquetaImg(seleccionado);
            cargarImagen(imagen);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null && dgvArticulos.Rows.Count > 0)
            {
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            int maximo = seleccionado.ListaImagenes.Count;

            if (seleccionado.IndiceImagen == maximo - 1)
                seleccionado.IndiceImagen = 0;
            else
                seleccionado.IndiceImagen++;

            string imagen = seleccionado.ListaImagenes[seleccionado.IndiceImagen].Url;
            configEtiquetaImg(seleccionado);
            cargarImagen(imagen);
        }

        //FILTRO RAPIDO
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaFiltrada;
            ArticuloNegocio Negocio = new ArticuloNegocio();
            ListaFiltrada = Negocio.listar();
            string text = txtFiltroRapido.Text;

            if (text != "")
            {
                ListaFiltrada = ListaFiltrada.FindAll(x => x.Nombre.ToLower().Contains(text.ToLower()) || x.Descripcion.ToLower().Contains(text.ToLower()) || x.Codigo.ToLower().Contains(text.ToLower()));
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = ListaFiltrada;
            ajusteColumnas();
        }

        //SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //FUNCIONES

        //RECARGAR VENTANA
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                configEtiquetaImg(listaArticulos[0]);
                cargarImagen(listaArticulos[0].ListaImagenes[0].Url);
                ajusteColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //RECARGAR IMAGEN
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://mcfil.net.ar/wp-content/uploads/2021/04/no-dispnible.jpg");
            }
        }

        //AJUSTES PERSONALIZADOS
        private void ajusteColumnas()
        {
            //OCULTAR COLUMNAS
            dgvArticulos.Columns["IndiceImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            //AJUSTAR TAMAÑOS
            dgvArticulos.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvArticulos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvArticulos.Columns["marca_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvArticulos.Columns["categoria_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvArticulos.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //JUSTIFICAR CONTENIDO
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //AJUSTE FORMATOS
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }

        private void configEtiquetaImg(Articulo seleccionado)
        {
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int cantImagenes = seleccionado.ListaImagenes.Count;
            int imgActual = seleccionado.IndiceImagen + 1;
            lblImagen.Text = imgActual + "/" + cantImagenes;

            //POSICIÓN ETIQUETA
            int btnIzquierdo = btnAnterior.Location.X;
            int btnDerecho = btnSiguiente.Location.X + btnSiguiente.Width;
            int posicionCentrada = (btnDerecho + btnIzquierdo) / 2;
            lblImagen.Location = new Point(posicionCentrada - (lblImagen.Width / 2), lblImagen.Location.Y);
        }

        private void dgvArticulos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                pbxImagen.Visible = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                lblImagen.Visible = true;
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                configEtiquetaImg(seleccionado);
                cargarImagen(seleccionado.ListaImagenes[0].Url);
            }
            else
            {
                pbxImagen.Visible = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                lblImagen.Visible = false;
            }
        }
    }
}
