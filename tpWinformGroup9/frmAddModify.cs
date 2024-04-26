using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tpWinformGroup9.Modelo;
using tpWinformGroup9.Negocio;


namespace tpWinformGroup9
{
    public partial class frmAddModify : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAddModify()
        {
            InitializeComponent();
        }

        public frmAddModify(Articulo articulo) //segundo constructor para el filtrado al momento de modificar un articulo
        {
            InitializeComponent();
            this.articulo = articulo;
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

                articulo.Categoria = (Categoria)categoriaComboBx.SelectedItem; //falta codigo para agregar un listado
                articulo.Marca = (Marca)marcaComboBx.SelectedItem; //falta codigo para agregar un listado

                if (precioTextBox.Text != null)
                    articulo.Precio = decimal.Parse(precioTextBox.Text);

                articulo.Imagen = new Imagen();
                if (textBox3 != null)
                {
                    if (!string.IsNullOrEmpty(textBox3.Text))
                    {
                        articulo.Imagenes.Add(textBox3.Text);
                        articulo.Imagen.ImagenUrl = textBox3.Text;
                    }
                    else
                        camposIncompletos = true;
                }

                if (camposIncompletos)
                {
                    MessageBox.Show("Los campos no pueden estar vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codigoTextBox.Focus();
                }

                // codigo dejado para posible agregado, REVISAR
                /*else
                {
                    if (articulo.ID != 0)
                    {
                        negocio.Modificar(articulo);
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Articulo añadido correctamente!");
                    }*/

                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo añadido correctamente!");
                }
                /*
                    //distingue si las guarda en la base de datos o localmente
                    if (archivo != null && !(textBox3.Text.ToUpper().Contains("HTTP")))
                    {
                        copiarImagenLocalmente();
                    }
                */
                Close();

            }
            catch (FormatException)
            {
                lblError.Text = "Por favor, cargar sólo numeros";
                lblError.Visible = true;
            }
        }

        /*private void copiarImagenLocalmente()
        {
            try
            {
                //copia la imagen a una carpeta local
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes-app"] + archivo.SafeFileName);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Ya hay un archivo con la misma imagen, elija otra por favor :)");
                throw;
            }
        }*/
    }
}
