using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Cliente
    {
        private string Nombre { get; set; }
        private string Direccion { get; set; }

      
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void SetDireccion(string direccion) 
        {
            Direccion= direccion;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetDireccion()
        {
            return Direccion;
        }
        public void Pago()
        {
            Console.WriteLine("Procesado el pago del cliente..");
        }


    }
}
