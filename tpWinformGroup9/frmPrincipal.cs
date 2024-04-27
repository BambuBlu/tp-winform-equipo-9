using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tpWinformGroup9.Modelo;
using tpWinformGroup9.Negocio;

namespace tpWinformGroup9
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaarticulos;
        private List<Imagen> listaImagen;
        
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            frmAddModify addWindow = new frmAddModify();
            addWindow.ShowDialog();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAddModify addWindow = new frmAddModify(articuloSeleccionado); //Se le manda el articulo seleccionado para poder modificarlo
            addWindow.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagen = imagenNegocio.listar();

            listaarticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaarticulos;
            brandComboBox.DataSource = marcaNegocio.listar();
            brandComboBox.ValueMember = "Id";
            brandComboBox.DisplayMember = "Descripcion";
            categoryComboBox.DataSource = categoriaNegocio.listar();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Descripcion";
            articleImage.Load(listaImagen[4].ImagenUrl);
          
        }

      

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagen = imagenNegocio.listar();
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Imagen imagenSeleccion = listaImagen.Find(imagen => imagen.IdArticulo == seleccion.ID);

            if (imagenSeleccion != null)
            {
                articleImage.Load(imagenSeleccion.ImagenUrl);

            }
            else { }
        }
        



        /* private void listaArticulos_SelectionChangeCommitted(object sender, EventArgs e)
         {
             ArticuloNegocio negocio = new ArticuloNegocio();
             List<Articulo> listaArt = negocio.listar(); //se abstrajo el listado de articulos para que actue como una funcion de llamado, quiza habria que modificarla
             List<Articulo> selecArt = new List<Articulo>();

             foreach (var articulo in listaArt)
             {
                 if (articulo.Nombre == dgvArticulos.SelectedColumns.ToString())
                 {
                     selecArt.Add(articulo);
                     dgvArticulos.DataSource = selecArt.FirstOrDefault();
                 }

             }
         }No termino de entender que hace esto*/
    }
}
