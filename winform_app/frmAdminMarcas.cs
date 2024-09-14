using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmAdminMarcas : Form
    {
        private List<Marca> listaMarcas;
        private Marca marca = null;
        public frmAdminMarcas()
        {
            InitializeComponent();
        }

        private void frmAdminMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
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
            frmAltaMarca altaMarca = new frmAltaMarca();
            altaMarca.ShowDialog();

            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca selectMarca;
            selectMarca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            frmAltaMarca modificarMarca = new frmAltaMarca(selectMarca);
            modificarMarca.ShowDialog();

            cargar();
        }

    }
}
