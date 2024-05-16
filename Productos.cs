namespace VentasInternet
{
    public class Productos
    {

        public string codigo {  get; set; }
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public int precioCompra { get; set; }

        public int precioVenta {  get; set; }

        public Productos()
        {
            codigo = string.Empty;
            nombre = string.Empty;
            descripcion = string.Empty;
            



        }

    }
}
