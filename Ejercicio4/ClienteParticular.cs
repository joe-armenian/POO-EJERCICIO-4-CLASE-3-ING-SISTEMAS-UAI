using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
     public class ClienteParticular:Cliente
    {
        public string TarjetaNmr { get; set; }

        public new void Pago()
        {
            Console.WriteLine("Procesando el pago del cliente particular...");
        }
    }
}
