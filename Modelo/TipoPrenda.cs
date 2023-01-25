namespace Modelo
{
    public class TipoPrenda
    {
        public string Codigo { get; set; }
        public string CodigoPrenda { get; set; }
        public string Descripcion { get; set; }
        public override string ToString() => Descripcion;
    }
}
