using System;
using System.Collections.Generic;
using System.Linq;
using tpWinformGroup9.Modelo;

namespace tpWinformGroup9.Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArt = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)accesoDatos.Lector["Id"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["Categoria"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    

                    listaArt.Add(aux);


                }

                return listaArt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
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