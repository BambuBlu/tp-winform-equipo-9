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

            cargar_Componentes();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAddModify addWindow = new frmAddModify(articuloSeleccionado); //Se le manda el articulo seleccionado para poder modificarlo
            addWindow.ShowDialog();

            cargar_Componentes();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el articulo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.ID);
                }
                cargar_Componentes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private int indiceActual = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagen = imagenNegocio.listar();
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            List<Imagen> imagenSeleccion = listaImagen.Where(imagen => imagen.IdArticulo == seleccion.ID).ToList();        
            if (imagenSeleccion.Count >0)
            {
                indiceActual = (indiceActual + 1) % imagenSeleccion.Count;
                cargarImagen(imagenSeleccion[indiceActual].ImagenUrl);

            }
            else { }

        }
    }
}
