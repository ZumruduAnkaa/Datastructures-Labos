using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.UnitTesting
{
    public class DateChecker
    {
        public static bool CheckIfDateExists(int day, int month, int year)
        {
            //Check if date exists
            bool exists = false;
            int maxDay = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxDay = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    maxDay = 30;
                    break;

                case 2:
                    bool isLeapYear = false;
                    if (year % 4 == 0)
                    {
                        if (year % 100 != 0)
                            isLeapYear = true;
                    }


                    if (isLeapYear)
                    {
                        maxDay = 29;
                    }
                    else
                    {
                        maxDay = 28;

                    }
                    break;
                default:
                    break;


            }
            if (day > 0 && day <= maxDay)
                exists = true;

            return exists;
        }
    
    }
}
