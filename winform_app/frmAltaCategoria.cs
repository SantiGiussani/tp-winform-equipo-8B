using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmAltaCategoria : Form
    {
        //ATRIBUTOS
        private Categoria categoria = null;

        //CONSTRUCTORES
        public frmAltaCategoria()
        {
            InitializeComponent();
            Text = "Agregar Categoria";
        }
        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        //CARGA DE FORMULARIO
        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            configurarAutocompletado();
            if (categoria != null)
            {
                txtId.Text = categoria.Id.ToString();
                txtDescripcion.Text = categoria.Descripcion;
            }
        }

        //SALIR
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //ACEPTAR
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtDescripcion.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(categoria);
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
            List<Categoria> listaCategorias;
            CategoriaNegocio negocio = new CategoriaNegocio();

            // Crear una lista con las marcas
            listaCategorias = negocio.listar();

            // Crear una lista con las descripciones
            List<string> listaDescripciones = new List<string>();
            foreach (Categoria item in listaCategorias)
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
