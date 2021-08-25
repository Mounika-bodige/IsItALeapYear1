using System;

namespace IsItALeapYear1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public bool IsItALeapYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
