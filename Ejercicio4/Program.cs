using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola!,gracias por utilizar nuestro software.\n");
            Console.WriteLine("Indique si desea agregar un producto(1) o realizar un encargo(2).");
            string condicion=(Console.ReadLine());

            if (ValidarCondicion(condicion))
            {
                if (condicion=="1") //producto
                {
                    //Console.WriteLine("CONDICION1");
                    Console.Write("Ingrese el ID del producto(solo enteros):");
                    string id=(Console.ReadLine());

                    Console.Write("Ingrese el Coste del producto(puede ser decimales con ','(coma)):");
                    string coste = (Console.ReadLine());

                    if (ValidarNumero(id) && ValidarCoste(coste)) 
                    {

                        Producto unProducto = new Producto();
                        unProducto.ID =Convert.ToInt32(id);
                        unProducto.Coste = Convert.ToDecimal(coste);
                        //unProducto.InformacionProducto();


                        Console.Write("Ingrese el nombre del cliente:");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese la direccion del cliente:");
                        string direccion = Console.ReadLine();

                        if (ValidarNombre(nombre) && ValidarDireccion(direccion))
                        {
                            Cliente unCliente = new Cliente();
                            unCliente.SetNombre(nombre);
                            unCliente.SetDireccion(direccion);


                            Console.WriteLine("Indique el tipo de cliente, 1 para corporativo, 2 para particular:");
                            string tipoCliente = Console.ReadLine();


                            if (ValidarCondicion(tipoCliente))
                            {
                                if (tipoCliente == "1") //cliente corporativo
                                {
                                    Console.Write("Ingrese la cuenta del cliente corporativo:");
                                    string cuentaCop = Console.ReadLine();
                                    if (ValidarNumero(cuentaCop))
                                    {
                                        ClienteCorporativo clienteCorp=new ClienteCorporativo();
                                        clienteCorp.Cuenta = Convert.ToInt32(cuentaCop);
                                        Console.WriteLine("Datos del cliente:\n");
                                        Console.WriteLine($"Nombre del cliente:{unCliente.GetNombre()}-Direccion del cliente:{unCliente.GetDireccion()}- Cuenta del cliente:{clienteCorp.Cuenta}");
                                        Console.WriteLine("Datos del producto\n");
                                        unProducto.InformacionProducto();
                                        clienteCorp.Pago();

                                    }
                                }
                                else //cliente particular
                                {
                                    Console.WriteLine("Ingrese el numero de tarjeta del cliente particular:");
                                    string tarjetaPart = Console.ReadLine();
                                    if (ValidarNumero(tarjetaPart))
                                    {
                                        ClienteParticular clientePart = new ClienteParticular();
                                        clientePart.TarjetaNmr = tarjetaPart;
                                        Console.WriteLine("Datos del cliente:\n");
                                        Console.WriteLine($"Nombre del cliente:{unCliente.GetNombre()}\n-Direccion del cliente:{unCliente.GetDireccion()}\n- Cuenta del cliente:{clientePart.TarjetaNmr}\n");
                                        Console.WriteLine("Datos del producto\n");
                                        unProducto.InformacionProducto();
                                        clientePart.Pago();
                                    }
                                }
                            }
                        else
                        {
                            Console.WriteLine("Error en la entrada de datos para el cliente.");
                        }

                        }
                        else
                        {
                            Console.WriteLine("Error en el tipo de cliente ingresado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error en los datos de ID/Coste");
                    }
                }



                else //entraria por encargo
                {
                    Console.WriteLine("Ingrese la ID del encargo");
                    string idEncargo = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha del encargo");
                    string fecha=Console.ReadLine();
                    Console.WriteLine("Ingrese el valor del encargo");
                    string valorEncargo= Console.ReadLine();


                    if (ValidarNumero(idEncargo) && ValidarCoste(valorEncargo) && DateTime.TryParse(fecha, out DateTime fechaCorrecta))
                    {
                        Encargo unEncargo= new Encargo();
                        unEncargo.EncargoID = Convert.ToInt32(idEncargo);
                        unEncargo.Fecha = fechaCorrecta;
                        unEncargo.Valor = Convert.ToDecimal(valorEncargo);


                        Console.Write("Ingrese el nombre del cliente:");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese la direccion del cliente:");
                        string direccion = Console.ReadLine();

                        if (ValidarNombre(nombre) && ValidarDireccion(direccion))
                        {
                            Cliente unCliente = new Cliente();
                            unCliente.SetNombre(nombre);
                            unCliente.SetDireccion(direccion);


                            Console.WriteLine("Indique el tipo de cliente, 1 para corporativo, 2 para particular:");
                            string tipoCliente = Console.ReadLine();


                            if (ValidarCondicion(tipoCliente))
                            {
                                if (tipoCliente == "1") //cliente corporativo
                                {
                                    Console.Write("Ingrese la cuenta del cliente corporativo:");
                                    string cuentaCop = Console.ReadLine();
                                    if (ValidarNumero(cuentaCop))
                                    {
                                        ClienteCorporativo clienteCorp = new ClienteCorporativo();
                                        clienteCorp.Cuenta = Convert.ToInt32(cuentaCop);
                                        Console.WriteLine("Datos del cliente:\n");
                                        Console.WriteLine($"Nombre del cliente:{unCliente.GetNombre()}-Direccion del cliente:{unCliente.GetDireccion()}- Cuenta del cliente:{clienteCorp.Cuenta}");
                                        Console.WriteLine("Datos del encargo\n");
                                        unEncargo.InformacionEncargo();
                                        clienteCorp.Pago();

                                    }
                                }
                                else //cliente particular
                                {
                                    Console.WriteLine("Ingrese el numero de tarjeta del cliente particular:");
                                    string tarjetaPart = Console.ReadLine();
                                    if (ValidarNumero(tarjetaPart))
                                    {
                                        ClienteParticular clientePart = new ClienteParticular();
                                        clientePart.TarjetaNmr = tarjetaPart;
                                        Console.WriteLine("Datos del cliente:\n");
                                        Console.WriteLine($"Nombre del cliente:{unCliente.GetNombre()}\n-Direccion del cliente:{unCliente.GetDireccion()}\n- Cuenta del cliente:{clientePart.TarjetaNmr}\n");
                                        Console.WriteLine("Datos del encargo\n");
                                        unEncargo.InformacionEncargo();
                                        clientePart.Pago();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error en la entrada de datos para el cliente.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Error en el tipo de cliente ingresado");
                        }



                    }
                    else
                    {
                        Console.Write("Error en la entrada de datos para el encargo!");
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Error en entrada de datos");
            }
            
            
            Console.ReadKey();
        }

        public static bool ValidarNombre(string entrada)
        {
            return Regex.IsMatch(entrada, @"^[a-zA-Z ]+$");
        }

        public static bool ValidarCondicion(string entrada)
        {
            return Regex.IsMatch(entrada,@"^[1-2]+$");
        }
        public static bool ValidarNumero(string entrada)
        {
            return Regex.IsMatch(entrada, @"^[0-9]+$");
        }
       
        public static bool ValidarDireccion(string entrada)
        {
            return Regex.IsMatch(entrada, @"^[\w¡ ]+$");
        }

        public static bool ValidarCoste(string entrada)
        {
            return Regex.IsMatch(entrada, @"^[0,0-9,9]+$");
        }

    }
}
