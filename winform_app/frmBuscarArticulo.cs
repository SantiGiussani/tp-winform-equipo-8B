﻿using System;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvBuscarArticulo.DataSource = articuloNegocio.listarXcodigo(textBoxCodigo.Text);
                textBoxCodigo.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscarXnombre_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvBuscarArticulo.DataSource = articuloNegocio.listarXnombre((string)txtBoxNombre.Text);
                txtBoxNombre.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscarXdesc_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvBuscarArticulo.DataSource = articuloNegocio.listarXdesc((string)txtBoxDesc.Text);
                txtBoxDesc.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscarXmarca_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvBuscarArticulo.DataSource = articuloNegocio.listarXmarca((string)txtBoxMarca.Text);
                txtBoxMarca.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscarXcat_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvBuscarArticulo.DataSource = articuloNegocio.listarXcat((string)txtBoxCat.Text);
                txtBoxCat.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
