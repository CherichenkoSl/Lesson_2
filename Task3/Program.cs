using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int determinant=number%2;
            if(determinant==0)
            {
                System.Console.WriteLine("Введённое число чётное");
            }
            else
            {
                System.Console.WriteLine("Введённое число нечётное");
            }
        }
    }
}
