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
    public partial class frmBuscarXnombre : Form
    {
        public frmBuscarXnombre()
        {
            InitializeComponent();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvBuscarXnombre.DataSource = articuloNegocio.listarXnombre((string)txtBoxNombre.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
