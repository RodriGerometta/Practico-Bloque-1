using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practico_Bloque_1
{
    internal class ProductoRepository : IProductoRepository
    {
        // Propiedades
        private readonly List<Producto> _productos;

        // Constructores
        public ProductoRepository()
        {
            _productos = new List<Producto>
            {
                new Producto{Id = 1, Nombre = "Producto1", Precio = 1000, Categoria = "Categoria 1", Activo = true},
                new Producto{Id = 2, Nombre = "Producto2", Precio = 2000, Categoria = "Categoria 2", Activo = false},
                new Producto{Id = 3, Nombre = "Producto3", Precio = 3000, Categoria = "Categoria 3", Activo = true},
                new Producto{Id = 4, Nombre = "Producto4", Precio = 4000, Categoria = "Categoria 1", Activo = false},
                new Producto{Id = 5, Nombre = "Producto5", Precio = 5000, Categoria = "Categoria 2", Activo = true}
            };
        }


        // Metodos
        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            var category = _productos.Where(p => p.Categoria == categoria).ToList();
            return category;
        }

        public Producto ObtenerPorId(int id)
        {
            var product = _productos.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos.ToList();
        }
    }
}
