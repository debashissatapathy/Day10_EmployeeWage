using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EMployeeWages
{
    class UC1_Attendance
    {
        public void Attendance()
        {
            int isPresent = 1;
            Random random = new Random();
            int chk_emp = random.Next(0, 2);
            if (chk_emp == isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
