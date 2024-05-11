using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpWinformGroup9.Modelo;
using tpWinformGroup9.Negocio;

namespace tpWinformGroup9
{
    public partial class addImage : Form
    {
        private OpenFileDialog archivo = null;
        private Articulo articulo = null;

        public addImage(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Añadiendo Imagen...";
        }
        private void BtnCargarNuevaImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                urlTextBox.Text = archivo.FileName;
                cargar_imagen(archivo.FileName);

            }
        }
        private void cargar_imagen(string url_imagen)
        {
            try
            {
                pictureBox1.Load(url_imagen);
            }
            catch (Exception)
            {
                cargar_predeterminada();
            }
        }
        private void cargar_predeterminada()
        {
            pictureBox1.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
        }

        private void txtbxUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargar_imagen(urlTextBox.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
                if (urlTextBox != null)
                {
                    if (!string.IsNullOrEmpty(urlTextBox.Text))
                    {
                        articulo.Descripcion = urlTextBox.Text;
                        articulo.Imagenes.Add(urlTextBox.Text);
                        negocio.añadir(articulo);

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        urlTextBox.Focus();
                    }
                }
            }
            catch (System.IO.IOException)
            {
                throw;
            }
        }
    }
}
