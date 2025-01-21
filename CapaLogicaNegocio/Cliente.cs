namespace CapaLogicaNegocio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Cliente(int id, string nombre, string correo)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
        }
    }
}
