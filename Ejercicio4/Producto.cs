using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Producto
    {
        public int ID { get; set; }

        public decimal Coste { get; set; }

        public void InformacionProducto()
        {
            Console.WriteLine($"ID DEL PRODUCTO:{ID}");
            Console.WriteLine($"Costo del producto:{Coste}");
        }
    }
}
