using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class Accountant
    {


        public static bool AskForBonus(CompanyPositions worker, int hours)
        {

            if (hours >= (int)worker)
                return true;
            else
                return false;
        }
    }
}
