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
    public partial class frmAltaMarca : Form
    {
        //ATRIBUTOS
        private Marca marca = null;

        //CONSTRUCTORES
        public frmAltaMarca()
        {
            InitializeComponent();
            Text = "Agregar Marca";
        }
        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        //CARGA DE FORMULARIO
        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            configurarAutocompletado();
            if (marca != null)
            {
                txtId.Text= marca.Id.ToString();
                txtDescripcion.Text = marca.Descripcion;
            }
        }

        //SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //ACEPTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                    marca = new Marca();
                
                marca.Descripcion = txtDescripcion.Text;

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



        //FUNCIONES
        private void configurarAutocompletado()
        {
            List<Marca> listaMarcas;
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
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Opciones: Suggest, Append, SuggestAppend
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource; // Fuente personalizada
            txtDescripcion.AutoCompleteCustomSource = autoCompleteCollection; // Asignar la colección
        }
    } 
}
