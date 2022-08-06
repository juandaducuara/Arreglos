using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Clases
    {
        public void Tirar()
        {
            int d1, d2 ,d3;
            int intento=0;
            do
            {           
            Random rand = new Random();
            d1 = rand.Next(1, 7);
            d2 = rand.Next(1, 7);
            d3 = rand.Next(1, 7);
            Console.WriteLine("Dado 1=" + d1);
            Console.WriteLine("Dado 2=" + d2);
            Console.WriteLine("Dado 3=" + d3);
           
            if (d1 == d2 && d2 == d3 && d3 == d1)
            {
              Console.WriteLine("Ganaste");
            }
            else
            {
              Console.WriteLine("Perdiste");
            }
            intento++;
                Console.WriteLine($"Intento numero {intento}");
                Console.WriteLine("Presione enter para intentar nuevamente");
                Console.ReadKey();
            } while (d1!=d2 || d2!= d3 || d1!=d3);
        }
    }
}
