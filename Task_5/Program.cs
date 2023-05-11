using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_2;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new String('=', 70));
            Console.WriteLine("Скільки днів до дня народження?");
            Console.WriteLine(new String('=', 70));

            DateTime birthdate;
            while (true)
            {
                try
                {
                    Console.Write("Введіть дату народження (у форматі ДД.ММ.РРРР): ");
                    birthdate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("Помилка ввода дати спробуйте ще раз!");
                    Console.ResetColor();
                }
            }



            DateTime nextBirthday = new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day);

            if (nextBirthday < DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            TimeSpan timeUntilBirthday = nextBirthday - DateTime.Now;

            Console.Clear();
            Printer.Print($"До наступного дня народження залишилося {timeUntilBirthday.Days} днів.", 11);

            Console.ReadKey();

        }
    }
}
