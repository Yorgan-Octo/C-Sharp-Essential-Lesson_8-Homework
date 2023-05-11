using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class UserInterface
    {

        public static int UserInInt(string mesText)
        {

            int informarion;
            while (true)
            {
                try
                {
                    Console.Write(mesText);
                    informarion = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    MessageShow("Помилка, не вірні данні! ");
                } 
            }

            return informarion;
        }


        public static void MessageShow(string message)
        {
            ConsoleColor basColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = basColor;
        }



    }
}
