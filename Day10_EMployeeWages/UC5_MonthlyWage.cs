using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EMployeeWages
{
    class UC5_MonthlyWage
    {
        public void Monthly_Wage()
        {
            int DailyWage,WorkingHr, WagePerHr=20, WorkingDay=20, MonthlyWage;
            
            Random random = new Random();
            int Emp_type = random.Next(0, 3);
            switch (Emp_type)
            {
                case 0:
                    WorkingHr = 8;
                    DailyWage = WorkingHr * WagePerHr;
                    MonthlyWage = DailyWage * WorkingDay;
                    Console.WriteLine("Employee is a part time employee and daily wage is {0} and monthly wage is {1}", DailyWage, MonthlyWage);
                    break;
                case 1:
                    WorkingHr = 12;
                    DailyWage = WorkingHr * WagePerHr;
                    MonthlyWage = DailyWage * WorkingDay;
                    Console.WriteLine("Employee is a full time employee and daily wage is {0} and monthly wage is {1}", DailyWage, MonthlyWage);
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }

        }
    }
}
