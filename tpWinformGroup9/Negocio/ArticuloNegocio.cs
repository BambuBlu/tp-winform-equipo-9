using System.Collections.Generic;
using System;
using System.Windows.Forms;
using tpWinformGroup9.Modelo;
using tpWinformGroup9;
using System.Linq;

namespace tpWinformGroup9.Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lart = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.setConsulta("SELECT NOMBRE, MARCA, PRECIO, CANTIDAD, URLIMAGEN FROM ARTICULOS");
            accesoDatos.ejecutarLectura();

            while (accesoDatos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Nombre = (string)accesoDatos.Lector["NOMBRE"];
                aux.Marca.Descripcion = (string)accesoDatos.Lector["MARCA"];
                aux.Precio = accesoDatos.Lector.GetDecimal(2);
                aux.Cantidad = accesoDatos.Lector.GetInt32(3);

                lart.Add(aux);


            }

            accesoDatos.cerrarConexion();
            return lart;
        }

        public void agregar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = listar();

            Articulo articulo_aux = new Articulo();


            articulo_aux = lista.Last();


            nuevoArticulo.id_a_incrementar = articulo_aux.ID + 1;

            try
            {
                datos.setConsulta("INSERT INTO ARTICULOS ( CODIGO, NOMBRE, IDMARCA, IDCATEGORIA, Precio, DESCRIPCION) VALUES (@Codigo, @Nombre, @Marca, @Categoria, @Precio, @Descripcion)");
                // INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)"); ///Dejo este codigo para cuando se agregen las urls
                datos.setParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setParametro("@Marca", nuevoArticulo.Marca.Id);
                datos.setParametro("@Categoria", nuevoArticulo.Categoria.Id);
                datos.setParametro("@Precio", nuevoArticulo.Precio);
                datos.setParametro("@Descripcion", nuevoArticulo.Descripcion);


                ///agregado de la url de imagenes y su conexion a las id's
                /*if (nuevo_articulo.Imagenes.Count > 0)
                {
                    datos.setParametro("@IdArticulo", nuevo_articulo.id_a_incrementar);
                    datos.setParametro("@ImagenUrl", nuevo_articulo.Imagenes[0]);
                }
                else
                {
                    datos.setParametro("@IdArticulo", nuevo_articulo.id_a_incrementar);
                    datos.setParametro("@ImagenUrl", "Sin imagen");
                }*/
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
   
} 