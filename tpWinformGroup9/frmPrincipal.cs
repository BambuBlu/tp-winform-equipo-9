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
        private List<Articulo> listaArticulos;
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
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cargar_Componentes();

            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id_a_incrementar"].Visible = false;
            brandComboBox.DataSource = marcaNegocio.listar();
            brandComboBox.ValueMember = "Id";
            brandComboBox.DisplayMember = "Descripcion";
            categoryComboBox.DataSource = categoriaNegocio.listar();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Descripcion";

            /*ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagen = imagenNegocio.listar();

            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id_a_incrementar"].Visible = false;
            brandComboBox.DataSource = marcaNegocio.listar();
            brandComboBox.ValueMember = "Id";
            brandComboBox.DisplayMember = "Descripcion";
            categoryComboBox.DataSource = categoriaNegocio.listar();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Descripcion";
            cargarImagen(listaImagen[0].ImagenUrl);*/

        }

        private void cargar_Componentes()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();

                agruparImagenes(listaArticulos);

                eliminarRepetidos(listaArticulos);

                dgvArticulos.DataSource = listaArticulos;

                cargarImagen(listaImagen[0].ImagenUrl);

                ocultarColumnas();

                dgvArticulos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void agruparImagenes(List<Articulo> lista)
        {
            List<Articulo> repetidos = new List<Articulo>();
            repetidos = getRepetidos(lista);
            foreach (Articulo articulo in lista)
            {
                foreach (Articulo repetido in repetidos)
                {
                    if (repetido.ID == articulo.ID)
                    {
                        articulo.Imagenes.Add(repetido.Imagenes[0]);
                    }
                }
            }
        }

        private List<Articulo> getRepetidos(List<Articulo> lista)
        {
            HashSet<int> ids_revisados = new HashSet<int>();

            List<Articulo> repetidos = new List<Articulo>();

            foreach (Articulo articulo_actual in lista)
            {
                if (!ids_revisados.Add(articulo_actual.ID))
                {
                    repetidos.Add(articulo_actual);
                }
            }
            return repetidos;
        }

        private void eliminarRepetidos(List<Articulo> lista)
        {
            List<Articulo> repetidos = new List<Articulo>();
            repetidos = getRepetidos(lista);
            foreach (Articulo repetido in repetidos)
            {
                lista.Remove(repetido);
            }
        }


        private void ocultarColumnas()
        {
            dgvArticulos.Columns["IMAGEN"].Visible = false;
            dgvArticulos.Columns["id_a_incrementar"].Visible = false;
            return;
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagen = imagenNegocio.listar();
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Imagen imagenSeleccion = listaImagen.Find(imagen => imagen.IdArticulo == seleccion.ID);

            if (imagenSeleccion != null)
            {
                cargarImagen(imagenSeleccion.ImagenUrl);

            }
            else { }
        }


        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
