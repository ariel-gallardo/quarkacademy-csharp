namespace Modelo
{
    public class Vendedor
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Cotizacion> Cotizaciones { get; set; } = new List<Cotizacion>();
    }
}