using System.Security.Principal;

namespace tpWinformGroup9.Modelo
{
    public class Articulo
    {
        private string nombre;
        private string marca;
        private float precio;
        private int cantidad;

        public string Nombre
        { get { return nombre; }

        set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }

            set { marca = value; }
        }
        public float Precio
        {
            get { return precio; }

            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }

            set { cantidad = value; }
        }



    }
}
