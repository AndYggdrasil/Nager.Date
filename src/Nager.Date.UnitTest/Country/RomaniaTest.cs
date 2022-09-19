using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.Date.Extensions;
using System;
using System.Linq;

namespace Nager.Date.UnitTest.Country
{
    [TestClass]
    public class RomaniaTest
    {
        [TestMethod]
        public void TestRomania2017()
        {
            var year = 2017;
            var publicHolidays = DateSystem.GetPublicHolidays(year, CountryCode.RO).ToArray();

            Assert.AreEqual(new DateTime(year, 1, 1), publicHolidays[0].Date, $"{publicHolidays[0].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 2), publicHolidays[1].Date, $"{publicHolidays[1].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 24), publicHolidays[2].Date, $"{publicHolidays[2].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 14), publicHolidays[3].Date, $"{publicHolidays[3].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 16), publicHolidays[4].Date, $"{publicHolidays[4].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 17), publicHolidays[5].Date, $"{publicHolidays[5].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 1), publicHolidays[6].Date, $"{publicHolidays[6].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 1), publicHolidays[7].Date, $"{publicHolidays[7].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 4), publicHolidays[8].Date, $"{publicHolidays[8].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 5), publicHolidays[9].Date, $"{publicHolidays[9].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 8, 15), publicHolidays[10].Date, $"{publicHolidays[10].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 11, 30), publicHolidays[11].Date, $"{publicHolidays[11].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 1), publicHolidays[12].Date, $"{publicHolidays[12].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 25), publicHolidays[13].Date, $"{publicHolidays[13].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 26), publicHolidays[14].Date, $"{publicHolidays[14].Name} is wrong");
        }

        [TestMethod]
        public void TestRomania2018()
        {
            var year = 2018;
            var publicHolidays = DateSystem.GetPublicHolidays(year, CountryCode.RO).ToArray();

            Assert.AreEqual(new DateTime(year, 1, 1), publicHolidays[0].Date, $"{publicHolidays[0].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 2), publicHolidays[1].Date, $"{publicHolidays[1].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 24), publicHolidays[2].Date, $"{publicHolidays[2].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 6), publicHolidays[3].Date, $"{publicHolidays[3].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 8), publicHolidays[4].Date, $"{publicHolidays[4].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 9), publicHolidays[5].Date, $"{publicHolidays[5].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 1), publicHolidays[6].Date, $"{publicHolidays[6].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 27), publicHolidays[7].Date, $"{publicHolidays[7].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 28), publicHolidays[8].Date, $"{publicHolidays[8].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 1), publicHolidays[9].Date, $"{publicHolidays[9].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 8, 15), publicHolidays[10].Date, $"{publicHolidays[10].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 11, 30), publicHolidays[11].Date, $"{publicHolidays[11].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 1), publicHolidays[12].Date, $"{publicHolidays[12].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 25), publicHolidays[13].Date, $"{publicHolidays[13].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 26), publicHolidays[14].Date, $"{publicHolidays[14].Name} is wrong");
        }

        [TestMethod]
        public void TestRomania2019()
        {
            var year = 2019;
            var publicHolidays = DateSystem.GetPublicHolidays(year, CountryCode.RO).ToArray();

            Assert.AreEqual(new DateTime(year, 1, 1), publicHolidays[0].Date, $"{publicHolidays[0].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 2), publicHolidays[1].Date, $"{publicHolidays[1].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 24), publicHolidays[2].Date, $"{publicHolidays[2].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 26), publicHolidays[3].Date, $"{publicHolidays[3].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 28), publicHolidays[4].Date, $"{publicHolidays[4].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 29), publicHolidays[5].Date, $"{publicHolidays[5].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 1), publicHolidays[6].Date, $"{publicHolidays[6].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 1), publicHolidays[7].Date, $"{publicHolidays[7].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 16), publicHolidays[8].Date, $"{publicHolidays[8].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 17), publicHolidays[9].Date, $"{publicHolidays[9].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 8, 15), publicHolidays[10].Date, $"{publicHolidays[10].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 11, 30), publicHolidays[11].Date, $"{publicHolidays[11].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 1), publicHolidays[12].Date, $"{publicHolidays[12].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 25), publicHolidays[13].Date, $"{publicHolidays[13].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 26), publicHolidays[14].Date, $"{publicHolidays[14].Name} is wrong");
        }

        [TestMethod]
        public void TestRomania2020()
        {
            var year = 2020;
            var publicHolidays = DateSystem.GetPublicHolidays(year, CountryCode.RO).ToArray();

            Assert.AreEqual(new DateTime(year, 1, 1), publicHolidays[0].Date, $"{publicHolidays[0].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 2), publicHolidays[1].Date, $"{publicHolidays[1].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 24), publicHolidays[2].Date, $"{publicHolidays[2].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 17), publicHolidays[3].Date, $"{publicHolidays[3].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 19), publicHolidays[4].Date, $"{publicHolidays[4].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 20), publicHolidays[5].Date, $"{publicHolidays[5].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 1), publicHolidays[6].Date, $"{publicHolidays[6].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 1), publicHolidays[7].Date, $"{publicHolidays[7].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 7), publicHolidays[8].Date, $"{publicHolidays[8].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 8), publicHolidays[9].Date, $"{publicHolidays[9].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 8, 15), publicHolidays[10].Date, $"{publicHolidays[10].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 11, 30), publicHolidays[11].Date, $"{publicHolidays[11].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 1), publicHolidays[12].Date, $"{publicHolidays[12].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 25), publicHolidays[13].Date, $"{publicHolidays[13].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 26), publicHolidays[14].Date, $"{publicHolidays[14].Name} is wrong");
        }

        [TestMethod]
        public void TestRomania2021()
        {
            var year = 2021;
            var publicHolidays = DateSystem.GetPublicHolidays(year, CountryCode.RO).ToArray();

            Assert.AreEqual(new DateTime(year, 1, 1), publicHolidays[0].Date, $"{publicHolidays[0].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 2), publicHolidays[1].Date, $"{publicHolidays[1].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 1, 24), publicHolidays[2].Date, $"{publicHolidays[2].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 4, 30), publicHolidays[3].Date, $"{publicHolidays[3].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 1), publicHolidays[4].Date, $"{publicHolidays[4].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 2), publicHolidays[5].Date, $"{publicHolidays[5].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 5, 3), publicHolidays[6].Date, $"{publicHolidays[6].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 1), publicHolidays[7].Date, $"{publicHolidays[7].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 20), publicHolidays[8].Date, $"{publicHolidays[8].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 6, 21), publicHolidays[9].Date, $"{publicHolidays[9].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 8, 15), publicHolidays[10].Date, $"{publicHolidays[10].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 11, 30), publicHolidays[11].Date, $"{publicHolidays[11].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 1), publicHolidays[12].Date, $"{publicHolidays[12].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 25), publicHolidays[13].Date, $"{publicHolidays[13].Name} is wrong");
            Assert.AreEqual(new DateTime(year, 12, 26), publicHolidays[14].Date, $"{publicHolidays[14].Name} is wrong");
        }

        [TestMethod]
        [DataRow(2018, 10, 8, false)]
        [DataRow(2018, 10, 9, false)]
        [DataRow(2018, 10, 10, false)]
        [DataRow(2018, 10, 11, false)]
        [DataRow(2018, 10, 12, false)]
        [DataRow(2018, 10, 13, true)]
        [DataRow(2018, 10, 14, true)]
        public void ChecksThatUniversalWeekendIsUsed(int year, int month, int day, bool expected)
        {
            var date = new DateTime(year, month, day);
            var isWeekend = date.IsWeekend(CountryCode.RO);
            Assert.AreEqual(expected, isWeekend);
        }
    }
}