using System.ComponentModel;
using System;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace tpWinformGroup9.Modelo
{
    public class Articulo
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca Marca { get; set; }  //contendria la id, la descripcion y alguna posible funcion
        public Categoria Categoria { get; set; } //contendria la id, la descripcion y alguna posible funcion
        public decimal Precio { get; set; }
        public Imagen Imagen { get; set; } //contendria la conexion de id con id de articulo, la url y alguna posible funcion.

        public List<String> Imagenes;

        public int id_a_incrementar { get; set; }
    }
}
