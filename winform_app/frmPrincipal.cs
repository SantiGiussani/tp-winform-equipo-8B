using dominio;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal() 
        {
            InitializeComponent();
        }

        private void MenuListado_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmArticulos))
                {
                    return;
                }
            }

            frmArticulos ventana = new frmArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void busquedaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscarArticulo))
                {
                    return;
                }
            }

            frmBuscarArticulo ventana = new frmBuscarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregarArticulo))
                {
                    return;
                }
            }

            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca altaMarca = new frmAgregarMarca();
            altaMarca.ShowDialog();
        }
    }
}
