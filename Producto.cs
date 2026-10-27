using System;
using System.Collections.Generic;
using System.Text;

namespace Practico_Bloque_1
{
    internal class Producto
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public bool Activo { get; set; }
    }
}
