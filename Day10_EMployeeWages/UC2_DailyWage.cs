using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EMployeeWages
{
    class UC2_DailyWage
    {
        public void DailyWage()
        {
            int WagePerHr = 20;
            int FullDayHr = 8;
            int DailyWage = WagePerHr * FullDayHr;
                Console.WriteLine("Employee daily wage is " + DailyWage);
        }
    }
}
