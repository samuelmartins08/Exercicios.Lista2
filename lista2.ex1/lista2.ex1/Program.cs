using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor : ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {

                Console.WriteLine("O número: {0} é o maior", num1);

            }
            else
            {

                Console.WriteLine("O número: {0} é o maior", num2);
            }
            
        }
    }
}
