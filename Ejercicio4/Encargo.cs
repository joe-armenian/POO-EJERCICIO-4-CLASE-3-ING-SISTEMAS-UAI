using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Encargo
    {
        public int EncargoID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }

        public void InformacionEncargo()
        {
            Console.WriteLine($"ID del encargo:{EncargoID}");
            Console.WriteLine($"Fechad del encargo:{Fecha}");
            Console.WriteLine($"Valor del encargo:{Valor}");
        }

    }
}
