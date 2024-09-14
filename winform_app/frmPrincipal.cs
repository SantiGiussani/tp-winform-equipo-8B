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
                    frmArticulos frmArticulos = (frmArticulos)item;
                    frmArticulos.Close();
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
                    frmBuscarArticulo frmBuscarArticulo = (frmBuscarArticulo)item;
                    frmBuscarArticulo.Close();
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
                    frmAgregarArticulo frmAgregarArticulo = ( frmAgregarArticulo)item;
                    frmAgregarArticulo.Close();
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

        private void administrarArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAdministrarArticulo))
                {
                    frmAdministrarArticulo frmAdministrarArticulo = (frmAdministrarArticulo)item;
                    frmAdministrarArticulo.Close();
                    return;
                }
            }

            frmAdministrarArticulo ventana = new frmAdministrarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
