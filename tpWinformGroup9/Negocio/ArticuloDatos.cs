using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpWinformGroup9.Modelo;
using System.Data.SqlClient; //Se debe agregar esta libreria para trabajar con base de datos

namespace tpWinformGroup9.Negocio
{
     class ArticuloDatos
    {
        public List<Articulo> listar()
        { 
          List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();//se iniciliza la conexion 
            SqlCommand comando = new SqlCommand();//se inicializa el comando
            SqlDataReader lector;//se crea el obejeto lector 

            try
            {
                /*Se establecen los parametros de conexion en la seccion de server esta el . para no tener que cambiar nada 
                 * indistintamente para cual de nosotros este haciendo pruebas con el codigo, la otra opccion es poner el nombre del desktop segun figura en tu pc */
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=TP_2_PROGRAMACION_3; integrated security=true"; /* en la seccion de integrated security si estas usando la autentificaciond de sql server tenes que poner el usuario y la contraseña  */
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NOMBRE, MARCA, PRECIO, CANTIDAD FROM ARTICULO";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Nombre = (string)lector["NOMBRE"];
                    aux.Marca = (string)lector["MARCA"];
                    aux.Precio = (float)lector.GetDecimal(2); //validar el tipo de dato que sera traido de la DB y entre () el subindice de la columna
                    aux.Cantidad = lector.GetInt32(3);

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

           

        }
    }
}
