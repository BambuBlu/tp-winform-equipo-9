using System;
using System.Collections.Generic;
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
        
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.setConsulta("SELECT NOMBRE FROM ARTICULOS");
            accesoDatos.ejecutarLectura();
            
            while (accesoDatos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Nombre = (string)accesoDatos.Lector["NOMBRE"];
                listaArticulos.Items.Add(aux.Nombre);

            }

            accesoDatos.cerrarConexion();
        }

        private void listaArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lart = negocio.listar(); //se abstrajo el listado de articulos para que actue como una funcion de llamado, quiza habria que modificarla

            string seleccion = listaArticulos.SelectedItem.ToString();
            List<Articulo> articuloSeleccionado = new List<Articulo>();
            for (int i = 0; i < lart.Count; i++)
            {

                if (seleccion == lart[i].Nombre)
                { 
                    articuloSeleccionado.Add(lart[i]);
                
                }
               
            }
            dgvArticulos.DataSource = articuloSeleccionado;


        }
    }
}
