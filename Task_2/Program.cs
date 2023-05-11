using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введіть текст: ");
            string strokaInuser = Console.ReadLine();


            Console.Clear();

            object element;
            while (true)
            {
                try
                {

                    Console.Write("Список кольорів: ");
                    for (int i = (int)MyColorEnum.blue; i <= (int)MyColorEnum.cyan; i++)
                    {
                        Console.Write((MyColorEnum)i + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Введіть колір: ");
                    string colorInUser = Console.ReadLine().ToLower();

                    element = Enum.Parse(typeof(MyColorEnum), colorInUser);
                    break;

                }
                catch (Exception)
                {
                    Console.Clear();
                    //можно булоб і так зробити
                    MessageShow("Не вірний колір", ConsoleColor.Red);
                    
                }
            }

            Console.Clear();
            Printer.Print(strokaInuser, (int)element);

            Console.ReadLine();

        }


        public static void MessageShow(string message, ConsoleColor color)
        {

            ConsoleColor basColor = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = basColor;
        }


    }
}
