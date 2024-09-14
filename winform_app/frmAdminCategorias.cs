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
    public partial class frmAdminCategorias : Form
    {
        private List<Categoria> listaCategorias;
        private Categoria categoria = null;
        public frmAdminCategorias()
        {
            InitializeComponent();
        }

        private void frmAdminCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
                //ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCategoria altaCategoria = new frmAltaCategoria();
            altaCategoria.ShowDialog();

            cargar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Categoria selectCategoria;
            selectCategoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            frmAltaCategoria modificarCategoria = new frmAltaCategoria(selectCategoria);
            modificarCategoria.ShowDialog();

            cargar();
        }
    }
}
