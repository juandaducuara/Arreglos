using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    
    class Program
    {
        
        public static void Main(string[] args)
        {
            metodos metodo = new metodos();
            Clases clasess = new Clases();
            string punto = "";
            do
            {
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("<=======================================================>");
            Console.WriteLine("Primer actividad trimestre");
            Console.WriteLine("Digite el punto deseado");
            punto = Console.ReadLine();
                switch (punto)
                {
                    case "1": primerPunto();
                        break;
                    case "2": segundoPunto();
                        break;
                    case "3": tercerPunto();
                        break;
                    case "4":
                        metodo.PrimerMetodo();
                        break;
                    case "5":
                        metodo.segundoMetodo();
                        break;
                    case "6":
                        metodo.tercerMetodo();
                        break;
                    case "7":
                        metodo.cuartoMetodo();
                        break;
                    case "8":
                        clasess.Tirar();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                            Console.WriteLine("opcion no valida");
                        break;
            }
            } while (punto!="0");

        }
        static void primerPunto()
        {
            int[] cantidadalum = new int[4];
            string[] nombrealum = new string[4];
            int[] examenp = new int[4];
            int[] exameno = new int[4];
            int[] examenf = new int[4];
            int[] promedio = new int[4];
            for (int c = 0; c < cantidadalum.Length; c++)
            {
                Console.WriteLine("Introdusca el nombre del alumno");
                Console.Write("Nombre alumno ==> ");
                nombrealum[c] = Console.ReadLine();
                Console.WriteLine($"Introduzca las notas de {nombrealum[c]}");
                Console.Write("Examen Parcial ==> ");
                examenp[c] = int.Parse(Console.ReadLine());
                Console.Write("Examen Oral ==> ");
                exameno[c] = int.Parse(Console.ReadLine());
                Console.Write("Examen Final ==> ");
                examenf[c] = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                for (int i = 0; i < promedio.Length; i++)
                {
                    promedio[i] = (examenp[i] + exameno[i] + examenf[i]) / 3;
                }

            }

            for (int i = 0; i < cantidadalum.Length; i++)
            {
                Console.WriteLine($"Nombre :{nombrealum[i]}\n Examen parcial: {examenp[i]} \n Examen oral : {exameno[i]} Examen final: {examenf[i]} Promedio: {promedio[i]}");
                if (promedio[i] >= 7)
                {
                    Console.WriteLine("APROBADO");
                }
                else
                {
                    Console.WriteLine("NO APROBADO");
                }
            }
        }
        static void segundoPunto()
        {
            string[] nombre = new string[5];
            string[] apellido = new string[5];
            int[] edad = new int[5];
            string[]sexo = new string[5];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"Introduzca el nombre del empleado {i+1}");
                nombre[i] = Console.ReadLine();
                Console.WriteLine($"Introduzca el apellido del empleado ");
                apellido[i] = Console.ReadLine();
                Console.WriteLine($"Introduzca la edad del empleado");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Introduzca el sexo del empleado");
                sexo[i] = Console.ReadLine();
                Console.WriteLine("<=======================================================>");
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"Datos empleado {i+1} \n Nombre : {nombre[i]} \n Apellidos :{apellido[i]} \n Edad : {edad[i]} \n Sexo: {sexo[i]} ");
                Console.WriteLine("<=======================================================>");
            }
        }

        static void tercerPunto()
        {
            int totalPago=0;
            Console.WriteLine("Digite la cantidad de productos que quiere ingresar ");
            int cantidadProd = int.Parse(Console.ReadLine());
            int [] precios = new int[cantidadProd];

            for (int i = 0; i < precios.Length; i++)
            {
                Console.Write("Digite el precio del producto " + (i+1) + "\n$");                
                precios[i] = Convert.ToInt32(Console.ReadLine());
                totalPago = precios[i] + totalPago;
                Console.WriteLine("<=======================================================>");
            }
            Console.WriteLine("Valor total a pagar = $" + totalPago); 
        }

    }
}
