using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите минимальную температуру воздуха за сутки:");
            string MinTemp = Console.ReadLine();
            System.Console.WriteLine("Введите максимальную температуру воздуха за сутки:");
            string MaxTemp = Console.ReadLine();
            double MinValue = Convert.ToDouble(MinTemp);
            double MaxValue = Convert.ToDouble(MaxTemp);
            Console.WriteLine($"Среднесуточная температура равна: {(MaxValue+MinValue)/2}{Convert.ToChar(176)}C");
        }
    }
}
