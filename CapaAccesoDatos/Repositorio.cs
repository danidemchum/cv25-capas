using System.Collections.Generic;
namespace CapaAccesoDatos

{
    public class Repositorio<T>
    {
        private List<T> datos = new List<T>();

        public IEnumerable<T> ObtenerTodos() => datos;

        public void Agregar(T entidad) => datos.Add(entidad);
    }
}

