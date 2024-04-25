//Habria que marcar los parametros

namespace tpWinformGroup9.Modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
