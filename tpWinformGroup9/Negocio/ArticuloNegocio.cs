using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
                datos.setConsulta("INSERT INTO ARTICULOS ( CODIGO, NOMBRE, IDMARCA, IDCATEGORIA, Precio, DESCRIPCION) VALUES (@Codigo, @Nombre, @Marca, @Categoria, @Precio, @Descripcion) INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setParametro("@Marca", nuevoArticulo.Marca.Id);
                datos.setParametro("@Categoria", nuevoArticulo.Categoria.Id);
                datos.setParametro("@Precio", nuevoArticulo.Precio);
                datos.setParametro("@Descripcion", nuevoArticulo.Descripcion);



                if (nuevoArticulo.Imagenes.Count > 0)
                {
                    datos.setParametro("@IdArticulo", nuevoArticulo.id_a_incrementar);
                    datos.setParametro("@ImagenUrl", nuevoArticulo.Imagenes[0]);
                }
                else
                {
                    datos.setParametro("@IdArticulo", nuevoArticulo.id_a_incrementar);
                    datos.setParametro("@ImagenUrl", "Sin imagen");
                }
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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion,idMarca = @marca,idCategoria = @categoria ,Precio = @precio where id = @id UPDATE IMAGENES SET ImagenUrl = '" + articulo.Imagen.ImagenUrl + "' where IdArticulo = @id");
                datos.setParametro("@id", articulo.ID);
                datos.setParametro("@codigo", articulo.Codigo);
                datos.setParametro("@nombre", articulo.Nombre);
                datos.setParametro("@descripcion", articulo.Descripcion);
                datos.setParametro("@precio", articulo.Precio);
                datos.setParametro("@marca", articulo.Marca.Id);
                datos.setParametro("@categoria", articulo.Categoria.Id);

                datos.ejecutarLectura();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
   
} 