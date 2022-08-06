using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class metodos
    {
        public void PrimerMetodo()
        {
            double dolar = 4429;
            double reales = 844;
            double rublo = 73.92;
            double euro = 4522;
            double yen = 32.73;
            Console.WriteLine(" Digite la moneda que desea convertir \n 1. Dolar \n 2.Reales \n 3.Rublo \n 4.Euro \n 5.Yen");
            string opcion = Console.ReadLine();
            Console.WriteLine("Digite el cantidad de dinero");
            double cantidadDin = double.Parse(Console.ReadLine());
            double conversion = 0;
            switch (opcion)
            {
                case "1" :
                    conversion = cantidadDin * dolar;
                    Console.WriteLine($"Cantidad Dinero en US$ {cantidadDin}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "2":
                    conversion = cantidadDin * reales;
                    Console.WriteLine($"Cantidad Dinero en R$ {cantidadDin}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "3":
                    conversion = cantidadDin * rublo;
                    Console.WriteLine($"Cantidad Dinero en ₽ {cantidadDin}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "4":
                    conversion = cantidadDin * euro;
                    Console.WriteLine($"Cantidad Dinero en € {cantidadDin}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "5":
                    conversion = cantidadDin * yen;
                    Console.WriteLine($"Cantidad Dinero en ¥ {cantidadDin}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;                
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }

        public void segundoMetodo()
        {
            double lado_1 = 0;
            double lado_2 = 0;
            Console.WriteLine("Ingrese el valor del primer lado del rectángulo:");
            lado_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del primer lado del rectángulo:");
            lado_2 = double.Parse(Console.ReadLine());
            double area = lado_1 * lado_2;
            Console.WriteLine("El área de su rectangulo es de: " + area);
        }
        public void tercerMetodo()
        {
            try
            {
                int edad = 0;
                Console.WriteLine("Digite su edad ");
                edad = Convert.ToInt32(Console.ReadLine());
                if (edad==0)
                {
                    Console.WriteLine("Error");
                }else if (edad < 18)
                {
                    Console.WriteLine("Usted es menor de edad");
                }
                else if (edad < 60)
                {
                    Console.WriteLine("Usted es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Usted es persona adulto mayor");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error caracter no valido");
            }

        }
        public void cuartoMetodo()
        {
            int numero = 0;
            Console.WriteLine("Digite la tabla de multiplicar que desea");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }

        }
    }
}
