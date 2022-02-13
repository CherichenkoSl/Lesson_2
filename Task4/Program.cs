using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shopName = "Супермаркет \"Шестерочка\"";
            string CompanyName = "ООО \"Агрофермер\"";
            string cashier = "Бубенко Алина Денисовна";
            DateTime data = DateTime.Now;
            string firstArticleName = "Молоко 2.5%";
            decimal firstArticlePrice = 65.90M;
            string secondArticleName = "Coca-Cola 2Л";
            decimal secondArticlePrice = 119.99M;
            string thirdArticleName = "Яблоки сезонные вес.";
            decimal thirdArticlePrice = 134.53M;
            string fourthArticleName = "Масло сливочное 200г";
            decimal fourthArticlePrice = 89.49M;
            decimal sum = firstArticlePrice + secondArticlePrice+ thirdArticlePrice+ fourthArticlePrice;
            int change = 500 - Convert.ToInt32(sum);
            string thx = "Спасибо за покупку!";
            System.Console.WriteLine("|*********************************|");
            System.Console.WriteLine($"|     {shopName}    |");
            System.Console.WriteLine($"|         {CompanyName}        |");
            System.Console.WriteLine("|*********************************|");
            System.Console.WriteLine($"| Кассир: {cashier} |");
            System.Console.WriteLine($"|       {data}       |");
            System.Console.WriteLine("|---------------------------------|");
            System.Console.WriteLine($"| {firstArticleName}...............{firstArticlePrice} |");
            System.Console.WriteLine($"| {secondArticleName}.............{secondArticlePrice} |");
            System.Console.WriteLine($"| {thirdArticleName}.....{thirdArticlePrice} |");
            System.Console.WriteLine($"| {fourthArticleName}......{fourthArticlePrice} |");
            System.Console.WriteLine("|---------------------------------|");
            System.Console.WriteLine($"| ИТОГО К ОПЛАТЕ:     {sum} руб. |");
            System.Console.WriteLine($"| Сдача:                  {change} руб. |");
            System.Console.WriteLine($"|       {thx}       |");
            System.Console.WriteLine("|*********************************|");
            System.Console.WriteLine("|_________________________________|");
        }
    }
}
