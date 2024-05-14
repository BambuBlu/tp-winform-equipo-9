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
    public partial class abmMarcaCategoria : Form
    {
        bool tipo;

        public abmMarcaCategoria()
        {
            InitializeComponent();
        }

        public abmMarcaCategoria(bool _tipo) //marcas 1, categorias 0
        {
            this.tipo = _tipo;

            InitializeComponent();

            if(tipo) //Marca
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                List<Marca> listaMarcas = marcaNegocio.listar().Distinct().ToList();
                dgvMarcaCategoria.DataSource = listaMarcas;
            }
            else
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                List<Categoria> listaCategorias = categoriaNegocio.listar().Distinct().ToList();
                dgvMarcaCategoria.DataSource = listaCategorias;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(dgvMarcaCategoria.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un item para continuar");
                return;
            }


            if (tipo) //Marca
            {
                MarcaNegocio marca = new MarcaNegocio();
                Marca seleccion = new Marca();

                if (abmTextBox.Text.Count() == 0)
                {
                    MessageBox.Show("No se admiten campos vacios");
                    return;
                }

                seleccion.Descripcion = abmTextBox.Text;

                marca.agregar(seleccion);
                MessageBox.Show("Articulo añadido correctamente!");
            }
            else //Categoria
            {
                CategoriaNegocio categoria = new CategoriaNegocio();
                Categoria seleccion = new Categoria();

                if (abmTextBox.Text.Count() == 0)
                {
                    MessageBox.Show("No se admiten campos vacios");
                    return;
                }

                seleccion.Descripcion = abmTextBox.Text;

                categoria.agregar(seleccion);
                MessageBox.Show("Articulo añadido correctamente!");
            }

            Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (dgvMarcaCategoria.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un item para continuar");
                return;
            }

            if (tipo) //Marca
            {
                MarcaNegocio marca = new MarcaNegocio();
                Marca seleccion = (Marca)dgvMarcaCategoria.CurrentRow.DataBoundItem;

                if(abmTextBox.Text.Count() == 0)
                {
                    MessageBox.Show("No se admiten campos vacios");
                    return;
                }

                string modificacion = abmTextBox.Text;


                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea modificar la marca?", "Modificado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        marca.modificar(seleccion, modificacion);
                        MessageBox.Show("Modificado correctamente");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
            else //Categoria
            {
                CategoriaNegocio marca = new CategoriaNegocio();
                Categoria seleccion = (Categoria)dgvMarcaCategoria.CurrentRow.DataBoundItem;

                if (abmTextBox.Text.Count() == 0)
                {
                    MessageBox.Show("No se admiten campos vacios");
                    return;
                }

                string modificacion = abmTextBox.Text;

                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea modificar la categoria?", "Modificado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        marca.modificar(seleccion, modificacion);
                        MessageBox.Show("Modificado correctamente");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvMarcaCategoria.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un item para continuar");
                return;
            }

            if (tipo) //Marca
            {
                MarcaNegocio marca = new MarcaNegocio();
                Marca seleccion = (Marca)dgvMarcaCategoria.CurrentRow.DataBoundItem;

                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar la marca?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        marca.Eliminar(seleccion.Id);
                        MessageBox.Show("Eliminado correctamente");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
            else //Categoria
            {
                CategoriaNegocio categoria = new CategoriaNegocio();
                Categoria seleccion = (Categoria)dgvMarcaCategoria.CurrentRow.DataBoundItem;

                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el articulo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        categoria.Eliminar(seleccion.Id);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            Close();
        }
    }
}
