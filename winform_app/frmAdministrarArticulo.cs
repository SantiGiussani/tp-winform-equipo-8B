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

        //CARGA FORMULARIO
        private void frmAdministrarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        //CAMBIO EN LA SELECCION DEL DGV
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
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

        //BOTONES
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            if (dgvArticulos.CurrentRow == null && dgvArticulos.Rows.Count > 0)
            {
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
            }
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

            if (dgvArticulos.CurrentRow == null && dgvArticulos.Rows.Count > 0)
            {
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
            }
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

        //ELIMINAR
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

        //EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarArticulo editarArticulo = new frmEditarArticulo(seleccionado);
            editarArticulo.ShowDialog();
            cargar();
        }

        //SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        //FUNCIONES

        //RECARGAR VENTANA
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ajusteColumnas();
                cargarImagen(listaArticulo[0].ListaImagenes[0]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //RECARGAR IMAGEN

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

        //AJUSTE COLUMNAS
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

        private void emprolijarDgv()
        {
            dgvArticulos.Columns["IndiceImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }
    }
}


