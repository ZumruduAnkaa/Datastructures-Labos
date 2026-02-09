using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures_ClassLibrary.UnitTesting;

namespace Datastructures_Unittesting.UnitTesting
{
    [TestClass]
    public class DateChecker_Test
    {
        [DataTestMethod]
        public void Test31012026()
        {
            int day = 31;
            int month = 1;
            int year = 2026;

            bool exists = DateChecker.CheckIfDateExists(day, month, year);

            Assert.AreEqual(true, exists);
        }

        [TestMethod]
        public void Test31082026()
        {
            int day = 31;
            int month = 8;
            int year = 2026;

            bool exists = DateChecker.CheckIfDateExists(day, month, year);

            Assert.AreEqual(true, exists);
        }
    }
}
