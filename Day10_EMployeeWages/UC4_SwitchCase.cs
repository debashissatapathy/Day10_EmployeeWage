using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EMployeeWages
{
    class UC4_SwitchCase
    {
        public void Employee_Type()
        {
            int DailyWage,WorkingHr, WagePerHr=20;
            
            Random random = new Random();
            int Emp_type = random.Next(0, 3);
            switch (Emp_type)
            {
                case 0:
                    WorkingHr = 8;
                    DailyWage = WorkingHr * WagePerHr;
                    Console.WriteLine("Employee is a part time employee and daily wage is {0}", DailyWage);
                    break;
                case 1:
                    WorkingHr = 12;
                    DailyWage = WorkingHr * WagePerHr;
                    Console.WriteLine("Employee is a full time employee and daily wage is {0}", DailyWage);
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }

        }
    }
}
