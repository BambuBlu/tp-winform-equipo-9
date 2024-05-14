using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            cargar_Componentes();
            CargarDataGrid();
            CargarCampoCbo();
            CargarMarcaCbo();
            CargarCategoriaCbo();

        }

        private void CbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(campoComboBox.SelectedItem == null)
            { 
                return; 
            }

            string opcion = campoComboBox.SelectedItem.ToString();
            if (opcion == "ID")
            {
                criterioComboBox.Items.Clear();
                criterioComboBox.Items.Add("Mayor a");
                criterioComboBox.Items.Add("Menor a");
                criterioComboBox.Items.Add("Igual a");
            }
            else
            {
                criterioComboBox.Items.Clear();
                criterioComboBox.Items.Add("Comienza con");
                criterioComboBox.Items.Add("Termina con");
                criterioComboBox.Items.Add("Contiene");
            }

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
            dgvArticulos.RowHeadersVisible = false;
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

        private void buttonBuscarFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string marca = "";
            string categoria = "";
            try
            {
                List<Articulo> lista_filtrada = new List<Articulo>();
                if (marcaComboBox.SelectedItem != null)
                {
                    marca = marcaComboBox.SelectedItem.ToString();
                }


                if (categoriacomboBox.SelectedItem != null)
                {
                    categoria = categoriacomboBox.SelectedItem.ToString();
                }
                lista_filtrada = negocio.filtrarMarcaCategoria(marca, categoria);

                if (validarFiltro())
                {
                    dgvArticulos.DataSource = lista_filtrada;
                    return;
                }
                string campo = campoComboBox.SelectedItem.ToString();
                string criterio = criterioComboBox.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;

                lista_filtrada = negocio.filtrar(lista_filtrada, campo, criterio, filtro);
                agruparImagenes(lista_filtrada);
                eliminarRepetidos(lista_filtrada);
                dgvArticulos.DataSource = lista_filtrada;

                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No se ha encontrado ningun resultado");
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {

            if (campoComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (criterioComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (campoComboBox.SelectedItem.ToString() == "ID")
            {

                if (string.IsNullOrEmpty(textBoxFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numericos...");
                    return true;
                }

                if (!(soloNumeros(textBoxFiltro.Text)))
                {
                    MessageBox.Show("Solo numeros para filtrar por el campo numerico...");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private int indiceActual = 0;
        private void siguienteImgButton_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagen = imagenNegocio.listar();
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            List<Imagen> imagenSeleccion = listaImagen.Where(imagen => imagen.IdArticulo == seleccion.ID).ToList();
            if (imagenSeleccion.Count > 0)
            {
                indiceActual = (indiceActual + 1) % imagenSeleccion.Count;
                cargarImagen(imagenSeleccion[indiceActual].ImagenUrl);

            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
            textBoxFiltro.Clear();
            criterioComboBox.SelectedItem = null;
            criterioComboBox.SelectedText = " ";

            campoComboBox.SelectedItem = null;
            campoComboBox.SelectedText = " ";

            categoriacomboBox.SelectedItem = null;
            categoriacomboBox.SelectedText = " ";

            marcaComboBox.SelectedItem = null;
            marcaComboBox.SelectedText = " ";
        }

        private void CargarCampoCbo()
        {
            campoComboBox.Items.Add("ID");
            campoComboBox.Items.Add("Nombre");
            campoComboBox.Items.Add("Descripcion");
        }

        private void CargarDataGrid()
        {
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id_a_incrementar"].Visible = false;
        }

        private void addImgButton_Click(object sender, EventArgs e)
        {
            Articulo articulo_seleccionado;
            articulo_seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            addImage nueva_imagen = new addImage(articulo_seleccionado);
            nueva_imagen.ShowDialog();
        }

        private void CargarMarcaCbo()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> listaMarcas = marcaNegocio.listar().Distinct().ToList();
            marcaComboBox.DataSource = listaMarcas;
            marcaComboBox.SelectedItem = null;
        }
        private void CargarCategoriaCbo() 
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> listaCategorias = categoriaNegocio.listar().Distinct().ToList();
            categoriacomboBox.DataSource = listaCategorias;
            categoriacomboBox.SelectedItem = null;

        }

        private void modifyMarcaButton_Click(object sender, EventArgs e)
        {

            abmMarcaCategoria abmMarca = new abmMarcaCategoria(true);
            abmMarca.ShowDialog();

            CargarMarcaCbo();
            cargar_Componentes();
        }

        private void modifyCategoriaButton_Click(object sender, EventArgs e)
        {

            abmMarcaCategoria abmMarcaCategoria = new abmMarcaCategoria(false);
            abmMarcaCategoria.ShowDialog();

            CargarCategoriaCbo();
            cargar_Componentes();
        }


        /*private void categoriacomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string marca = "";
            string categoria = "";
            try
            {


                if (marcaComboBox.SelectedItem != null)
                {
                    marca = marcaComboBox.SelectedItem.ToString();
                }


                if (categoriacomboBox.SelectedItem != null)
                {
                    categoria = categoriacomboBox.SelectedItem.ToString();
                }




                List<Articulo> lista_filtrada = new List<Articulo>();
                lista_filtrada = negocio.filtrarMarcaCategoria(marca, categoria);
                agruparImagenes(lista_filtrada);
                eliminarRepetidos(lista_filtrada);
                dgvArticulos.DataSource = lista_filtrada;

                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No se ha encontrado ningun resultado");
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }^*/

        /*private void marcaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string marca = "";
            string categoria = "";
            try
            {


                if (marcaComboBox.SelectedItem != null)
                {
                    marca = marcaComboBox.SelectedItem.ToString();
                }


                if (categoriacomboBox.SelectedItem != null)
                {
                    categoria = categoriacomboBox.SelectedItem.ToString();
                }




                List<Articulo> lista_filtrada = new List<Articulo>();
                lista_filtrada = negocio.filtrarMarcaCategoria(marca, categoria);
                agruparImagenes(lista_filtrada);
                eliminarRepetidos(lista_filtrada);
                dgvArticulos.DataSource = lista_filtrada;

                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No se ha encontrado ningun resultado");
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }*/
    }
}
