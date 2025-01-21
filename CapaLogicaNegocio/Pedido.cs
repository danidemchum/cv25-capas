using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> ListaDeProductos { get; private set; }
        public decimal Total { get; private set; }

        public Pedido(int id, Cliente cliente)
        {
            Id = id;
            Cliente = cliente;
            ListaDeProductos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            ListaDeProductos.Add(producto);
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Total = 0;
            foreach (var producto in ListaDeProductos)
            {
                Total += producto.Precio;
            }
        }
    }
}
