namespace Modelo
{
    public class Cotizacion
    {
        public string Identificacion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string CodigoVendedor { get; set; }
        public string CodigoPrenda { get; set; }
        public int Unidades { get; set; }
        public double Calculo { get; set; }
        public override string ToString() => $"{Identificacion} {Fecha.ToString("dd/MM/yy")} - V{CodigoVendedor} - P{CodigoPrenda} {Unidades}U {Calculo}$";
    }
}
