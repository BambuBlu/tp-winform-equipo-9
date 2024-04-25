//Habria que marcar los parametros

namespace tpWinformGroup9.Modelo
{
    public class Imagen
    {
        public int ID { get; set; }
        public int IdArticulo { get; set; }
        public string ImagenUrl { get; set; }

        public override string ToString()
        {
            return ImagenUrl;
        }
    }
}
