namespace Modelo
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public List<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
        public List<Prenda> Prendas { get; set; } = new List<Prenda>();

        public override string ToString() => $"Tienda {Nombre} - {Direccion}";
        
    }
}
