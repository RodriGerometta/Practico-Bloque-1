using Practico_Bloque_1;
using System.Runtime.InteropServices;

IProductoRepository repo = new ProductoRepository();

var productos = repo.ObtenerTodos();

Console.WriteLine("Todos los productos: ");
foreach (Producto p in productos)
{
    ImprimirProducto(p);
}

Console.WriteLine("Busqueda por id");
var busqueda = repo.ObtenerPorId(10);
if (busqueda is null)
{
    Console.WriteLine("No se encontro el producto");
}
else
{
    ImprimirProducto(busqueda);
}

Console.WriteLine("Busqueda por categoria: ");
var category = repo.BuscarPorCategoria("Categoria 1");
if (!category.Any() == true)
{
    Console.WriteLine("No se encontro la categoria");
}
else
{
    foreach (Producto c in category)
    {
        ImprimirProducto(c);
    }
}

Console.WriteLine("Agregar un producto nuevo");
repo.Agregar(new Producto { Id = 6, Nombre = "Producto6", Precio = 6000, Categoria = "Categoria 1", Activo = true });
var productos2 = repo.ObtenerTodos();
foreach (Producto p in productos2)
{
    ImprimirProducto(p);
}

static void ImprimirProducto(Producto p)
{
    Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio} - {p.Categoria}");
}