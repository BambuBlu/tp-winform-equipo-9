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
            listaArticulos.DataSource = articuloNegocio.listar();
            listaArticulos.ValueMember = "Id";
            listaArticulos.DisplayMember = "Nombre";
            brandComboBox.DataSource = marcaNegocio.listar();
            brandComboBox.ValueMember = "Id";
            brandComboBox.DisplayMember = "Descripcion";
            categoryComboBox.DataSource = categoriaNegocio.listar();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Descripcion";
        }

        private void listaArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Articulo> articuloSeleccionado = new List<Articulo>();
            //for (int i = 0; i < lart.Count; i++)
            //{

            //    if (seleccion == lart[i].Nombre)
            //    { 
            //        articuloSeleccionado.Add(lart[i]);

            //    }

            //}



        }

        private void listaArticulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArt = negocio.listar(); //se abstrajo el listado de articulos para que actue como una funcion de llamado, quiza habria que modificarla
            List<Articulo> selecArt = new List<Articulo>();

            foreach (var articulo in listaArt)
            {
                if (articulo.Nombre == listaArticulos.SelectedItem.ToString())
                {
                    selecArt.Add(articulo);
                    dgvArticulos.DataSource = selecArt.FirstOrDefault();
                }

            }
        }
    }
}
