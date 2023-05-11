using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class Printer
    {

        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(new String('=',70));
            Console.WriteLine(stroka);
            Console.WriteLine(new String('=', 70));
            Console.ResetColor();
        }

    }
}
