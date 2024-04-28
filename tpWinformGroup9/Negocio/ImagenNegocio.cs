using System;
using System.Collections.Generic;
using tpWinformGroup9.Modelo;

namespace tpWinformGroup9.Negocio
{
    internal class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> listaimagen = new List<Imagen>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsulta("SELECT IdArticulo, ImagenUrl FROM dbo.IMAGENES");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.IdArticulo = (int)accesoDatos.Lector["IdArticulo"];
                    imagen.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];

                    listaimagen.Add(imagen);
                }

                return listaimagen;
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
    }
}
