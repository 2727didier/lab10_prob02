using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_prob02
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                int opcion;

                Dictionary<string, int> ventas = new Dictionary<string, int>();

                do
                {
                    Console.Clear(); // Limpia la pantalla
                    Console.WriteLine("================================");
                    Console.WriteLine("Productos de mPhone");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Ventas de mPhone 3000");
                    Console.WriteLine("2: Ventas de mPad 3500");
                    Console.WriteLine("3: Ventas de MAPBrook 3800");
                    Console.WriteLine("4: Ventas de mWatch 8000");
                    Console.WriteLine("5: Salir");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                ventas["mPhone 3000"] = SubmenuVentas("mPhone 3000", ventas);
                                break;
                            case 2:
                                ventas["mPad 3500"] = SubmenuVentas("mPad 3500", ventas);
                                break;
                            case 3:
                                ventas["MAPBrook 3800"] = SubmenuVentas("MAPBrook 3800", ventas);
                                break;
                            case 4:
                                ventas["mWatch 8000"] = SubmenuVentas("mWatch 8000", ventas);
                                break;
                            case 5:
                                Console.WriteLine("Saliendo del programa...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                    }

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                } while (opcion != 5);
            }

            static int SubmenuVentas(string producto, Dictionary<string, int> ventas)
            {
                int opcion;
                int cantidadVentas = ventas.ContainsKey(producto) ? ventas[producto] : 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine($"Registrar Venta de {producto}");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Registrar Venta");
                    Console.WriteLine("2: Registrar Devolución");
                    Console.WriteLine("3: Menu Principal");
                    Console.WriteLine("================================");
                    Console.WriteLine($"Cantidad de Ventas de {producto}: {cantidadVentas}");
                    Console.Write("Ingrese una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese la cantidad de ventas a registrar: ");
                                if (int.TryParse(Console.ReadLine(), out int ventasNuevas))
                                {
                                    cantidadVentas += ventasNuevas;
                                    Console.WriteLine($"Se registraron {ventasNuevas} ventas de {producto}.");
                                }
                                else
                                {
                                    Console.WriteLine("Cantidad no válida. Intente de nuevo.");
                                }
                                break;
                            case 2:
                                Console.Write("Ingrese la cantidad de devoluciones a registrar: ");
                                if (int.TryParse(Console.ReadLine(), out int devoluciones))
                                {
                                    cantidadVentas -= devoluciones;
                                    if (cantidadVentas < 0)
                                    {
                                        cantidadVentas = 0;
                                        Console.WriteLine("No puede haber más devoluciones que ventas.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Se registraron {devoluciones} devoluciones de {producto}.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Cantidad no válida. Intente de nuevo.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Regresando al Menú Principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                    }

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                } while (opcion != 3);

                return cantidadVentas;
            }
        }





    }


