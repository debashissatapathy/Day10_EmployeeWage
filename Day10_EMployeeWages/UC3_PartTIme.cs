using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EMployeeWages
{
    class UC3_PartTime
    {
        public int Employee_PartTime()
        {
            int DailyWage,WorkingHr, WagePerHr=20;
            
            Random random = new Random();
            int Emp_type = random.Next(0, 2);
            if (Emp_type == 0)
            {
                WorkingHr = 8;
                DailyWage = WorkingHr * WagePerHr;
                Console.WriteLine("Employee is a part time employee and daily wage is {0}", DailyWage);
                return DailyWage;
            }
            else
                WorkingHr = 12;
                DailyWage = WorkingHr * WagePerHr;
                Console.WriteLine("Employee is a full time employee and daily wage is {0}",DailyWage);
                return DailyWage;


        }
    }
}
