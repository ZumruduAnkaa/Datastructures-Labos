using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.UnitTesting
{
    public class FineCalculation
    {
        public static int CalculateFine(int speed, int speedLimit, bool inSchoolZone)
        {
            int overSpeed = speed - speedLimit;

            if (overSpeed <= 0)
            {
                return 0;
            }
            if (overSpeed <= 9)
            {
                return 50;
            }
            if (overSpeed <= 19 && overSpeed >= 10)
            {
                return 100;
            }
            return -1;
        }
    }
}
