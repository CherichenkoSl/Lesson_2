using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите порядковый номер месяца:");
            int number = Convert.ToInt32(Console.ReadLine());
            string Month = "";
            switch (number)
            {
                case 1:
                    Month = "Январь";
                    break;
                case 2:
                    Month = "Февраль";
                    break;
                case 3:
                    Month = "Март";
                    break;
                case 4:
                    Month = "Апрель";
                    break;
                case 5:
                    Month = "Май";
                    break;
                case 6:
                    Month = "Июнь";
                    break;
                case 7:
                    Month = "Июль";
                    break;
                case 8:
                    Month = "Август";
                    break;
                case 9:
                    Month = "Сентябрь";
                    break;
                case 10:
                    Month = "Октябрь";
                    break;
                case 11:
                    Month = "Ноябрь";
                    break;
                case 12:
                    Month = "Декабрь";
                    break;
            }
            if (number > 0 && number <= 2 ||number==12)
            {
                System.Console.WriteLine("Укажите среднюю температуру");
                double averageTemp = Convert.ToDouble(Console.ReadLine());
                if (averageTemp >0)
                {
                    System.Console.WriteLine("Дождливая зима");
                    return;
                }
            }
                Console.WriteLine($"Текущий месяц: {Month}");
        }
    }
}
