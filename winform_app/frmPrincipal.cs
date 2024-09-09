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

        private void MenuLisatado_Click(object sender, EventArgs e)
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

        private void SubMnCodigo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBusquedaCodigo))
                {
                    return;
                }
            }

            frmBusquedaCodigo ventana = new frmBusquedaCodigo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBuscarXnombre))
                {
                    return;
                }
            }

            frmBuscarXnombre ventana = new frmBuscarXnombre();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
