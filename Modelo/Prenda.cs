namespace Modelo
{
    public class Prenda
    {
        public string Codigo { get; set; }
        public string CodigoCalidad { get; set; }
        public double PrecioUnitario { get; set; }
        public int StockActual { get; set; }
        public CalidadPrenda Calidad { get; set; }
        public List<TipoPrenda> TiposPrenda { get; set; }
        public override string ToString() => $"{Codigo} - {Calidad} - {PrecioUnitario}$ - {StockActual}U";
    }
}
