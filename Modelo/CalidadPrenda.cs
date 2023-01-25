namespace Modelo
{
    public class CalidadPrenda
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public override string ToString() => Descripcion;
    }
}
