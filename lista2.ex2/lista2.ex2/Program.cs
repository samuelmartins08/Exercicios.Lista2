using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2.ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os valores são identicos");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("O primeiro valor é maior que o segundo");

                }
                else
                {
                    Console.WriteLine("O segundo valor é maior que o primeiro");
                }



            }
        }
    }
}

