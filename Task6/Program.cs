using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        [Flags]
        public enum WorkDays
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thurtsday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }

        static void Main(string[] args)
        {
            WorkDays workOnWeekend = WorkDays.Saturday | WorkDays.Sunday;
            WorkDays Office = (WorkDays)0b0001110;
            WorkDays isworking = Office & workOnWeekend;
            bool isworkingOnSat = isworking == WorkDays.Saturday;
            bool isworkingOnSun = isworking == WorkDays.Sunday;
            bool isworkingOnWeek = isworking == workOnWeekend;
            if (isworkingOnSat || isworkingOnSun || isworkingOnWeek)
            {
                System.Console.WriteLine("ОФис работает в выходные!");
            }
            Console.WriteLine($"Дни работы офиса: {Office}");
        }
    }
}

