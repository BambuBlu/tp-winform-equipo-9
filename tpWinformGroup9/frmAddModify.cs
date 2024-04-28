using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tpWinformGroup9.Modelo;
using tpWinformGroup9.Negocio;


namespace tpWinformGroup9
{
    public partial class frmAddModify : Form
    {
        private Articulo articulo = null;
        private List<string> listaAuxImg = new List<string>();
        private OpenFileDialog archivo = null;

        public frmAddModify()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }

        public frmAddModify(Articulo articulo) //segundo constructor para el filtrado al momento de modificar un articulo
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {


            ArticuloNegocio negocio = new ArticuloNegocio();
            bool camposIncompletos = false;
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                if (articulo.Imagenes == null)
                    articulo.Imagenes = new List<string>();

                if (codigoTextBox.Text != null)
                    if (!string.IsNullOrEmpty(codigoTextBox.Text))
                        articulo.Codigo = codigoTextBox.Text;
                    else
                        camposIncompletos = true;

                if (textBox1.Text != null)
                    if (!string.IsNullOrEmpty(textBox1.Text))
                        articulo.Nombre = textBox1.Text;
                    else
                        camposIncompletos = true;

                if (textBox2.Text != null)
                    if (!string.IsNullOrEmpty(textBox2.Text))
                        articulo.Descripcion = textBox2.Text;
                    else
                        camposIncompletos = true;

                articulo.Categoria = (Categoria)categoriaComboBx.SelectedItem;
                articulo.Marca = (Marca)marcaComboBx.SelectedItem;

                if (precioTextBox.Text != null)
                    articulo.Precio = decimal.Parse(precioTextBox.Text);

                articulo.Imagen = new Imagen();

                if (listaAuxImg.Count != 0 )
                {
                    articulo.Imagenes.AddRange(listaAuxImg);
                    articulo.Imagen.ImagenUrl = textBox3.Text;
                }
                else
                    camposIncompletos = true;

                if (camposIncompletos)
                {
                    MessageBox.Show("Los campos no pueden estar vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codigoTextBox.Focus();
                }

                else
                {
                    if (articulo.ID != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Articulo añadido correctamente!");
                    }

                    Close();

                }
            }
            catch (FormatException)
            {
                lblError.Text = "Por favor, cargar sólo numeros";
                lblError.Visible = true;
            }
        }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                marcaComboBx.DataSource = marcaNegocio.listar();
                marcaComboBx.ValueMember = "Id";
                marcaComboBx.DisplayMember = "Descripcion";
                categoriaComboBx.DataSource = categoriaNegocio.listar();
                categoriaComboBx.ValueMember = "Id";
                categoriaComboBx.DisplayMember = "Descripcion";
                articleImage.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");

                if (articulo != null)
                {
                    codigoTextBox.Text = articulo.Codigo;
                    textBox1.Text = articulo.Nombre;
                    precioTextBox.Text = articulo.Precio.ToString();
                    marcaComboBx.SelectedValue = articulo.Marca.Id;
                    categoriaComboBx.SelectedValue = articulo.Categoria.Id;
                    textBox3.Text = articulo.Imagenes.First();
                    textBox2.Text = articulo.Descripcion;
                    cargarImagen(textBox3.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBox3.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                articleImage.Load(imagen);
            }
            catch (Exception)
            {
                articleImage.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");


            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if(!listaAuxImg.Contains(textBox3.Text))
                {
                    listaAuxImg.Add(textBox3.Text);
                }
            }
        }
    }
}
