using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CompanyPositions companyPosition;
            while (true)
            {

                Console.WriteLine(new String('-', 90));
                Console.WriteLine(" Список посад : ");
                Console.WriteLine(" 1 - SalesManager | 2 - ChiefEngineer | 3 - FinancialAnalyst | 4 - HRManager ");
                Console.WriteLine(new String('-', 90));
                int profesion = UserInterface.UserInInt("Выберыть посаду: ");


                if (profesion >= 1 && profesion <= 4)
                {
                    companyPosition = (profesion == 1) ? CompanyPositions.SalesManager
                        : (profesion == 2) ? CompanyPositions.ChiefEngineer
                        : (profesion == 3) ? CompanyPositions.FinancialAnalyst
                        : (profesion == 4) ? CompanyPositions.HRManager : default;
                    break;
                }
                else
                {
                    Console.Clear();
                    UserInterface.MessageShow("Такої посади немае! ");
                }

            }

            Console.Clear();
            int strokaInuser = UserInterface.UserInInt("Скількі часів відпращьованно: ");


            bool bonus = Accountant.AskForBonus(companyPosition, strokaInuser);


            string bonusMes;

            if (bonus)
                bonusMes = "Норма відпрацьована (Премія ДОЗВОЛЕННА)";
            else
                bonusMes = "Норма не відпрацьована (Премія НЕ Дозволенна)";

            Console.Clear();
            Console.WriteLine(new String('-', 90));
            Console.WriteLine(bonusMes);
            Console.WriteLine(new String('-', 90));
            Console.ReadKey();
        }
    }
}
