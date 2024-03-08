using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class ClienteCorporativo:Cliente
    {
        public int Cuenta { get; set; }

        public new void Pago()
        {
            Console.WriteLine("Procesado el pago del cliente corporativo....");
        }
    }
}
