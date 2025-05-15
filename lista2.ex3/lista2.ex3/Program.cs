using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2.ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o terceiro número: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("Os valores são iguais");

            }
            else {
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("O primeiro valor é o maior");
                } 
                if (num3 > num1 && num3 > num2)
                {
                    Console.WriteLine("O terceiro valor é o maior");
                }
                if (num2 > num1 &&  num2 > num3)
                {

                    Console.WriteLine("O segundo valor é o maior");
                }
            }
           

            


        }
    }
}
