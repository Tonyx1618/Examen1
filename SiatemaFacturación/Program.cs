using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SistemaFacturación
{
    class Program
    {
        static void Main(string[] args)
        {

            menu[] guardado = new articulo[4];


            string valida;
            int compara;

            Console.WriteLine("Elija una opción del menú: \n 1:Articulo \n 2:Facturación \n 3:Reporte \n 4:Salir");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {

                do
                {
                    Console.WriteLine("Articulos \n 1:Agregar articulo \n 2:Borrar ariculo \n 3:Consultar articulo");

                    string opcionarticulo = Console.ReadLine();



                    if (opcionarticulo == "1")
                    {

                        string sino = "si";
                        int contador = 0;



                        do
                        {

                            Console.WriteLine("Ingrese el codigo del articulo");

                            int codigoarticulo = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el nombre del articulo");

                            string nombrearticulo = Console.ReadLine();

                            Console.WriteLine("Ingrese el precio del articulo");

                            double precioarticulo = double.Parse(Console.ReadLine());

                            

                            Console.WriteLine("Articulo creado: ");

                            menu articulo1 = new articulo(codigoarticulo, nombrearticulo, precioarticulo);

                            guardado[contador] = articulo1;

                            


                        Console.WriteLine("Desea agregar otro articulo \n si \n no ");

                            sino = Console.ReadLine();

                            contador++;

                        } while (sino == "si" && contador <= 5);

                    }
                    else if (opcionarticulo == "2")
                    {

                    }
                    else if (opcionarticulo == "3")
                    {
                        Console.WriteLine("Ingrese el codigo del articulo");
                        compara = Int32.Parse(Console.ReadLine());


                        //int codigoarticulo = int.Parse(Console.ReadLine()); 

                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida");
                    }

                    Console.WriteLine("Desea volver al menu Articulo \n si \n no");
                    valida = Console.ReadLine();

                } while (valida == "si");

            }

            else if (opcion == "2")
            {
                


            }
            else if (opcion == "3")
            {


            }
            else if (opcion == "4")
            {


            }



            else
            {
                Console.WriteLine("Opción incorrecta");
            }

        }
    }
}
