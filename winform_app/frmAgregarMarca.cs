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
using System.Xml.Linq;

namespace winform_app
{
    public partial class frmAgregarMarca : Form
    {
        private List<Marca> listaMarcas;
        private Marca marca = null;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            configurarAutocompletado();
            //MODIFICACION
            if (marca != null)
            {
                txtMarca.Text = marca.Descripcion;       
            }           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtMarca.Text;

                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void configurarAutocompletado()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            // Crear una lista con las marcas
            listaMarcas = negocio.listar();

            // Crear una lista con las descripciones
            List<string> listaDescripciones = new List<string>();
            foreach (Marca item in listaMarcas)
            {
                listaDescripciones.Add(item.Descripcion);
            }

            // Crear una instancia de AutoCompleteStringCollection y agregar la lista
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(listaDescripciones.ToArray());

            // Asignar la colección al TextBox
            txtMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Opciones: Suggest, Append, SuggestAppend
            txtMarca.AutoCompleteSource = AutoCompleteSource.CustomSource; // Fuente personalizada
            txtMarca.AutoCompleteCustomSource = autoCompleteCollection; // Asignar la colección
        }
    }
}
