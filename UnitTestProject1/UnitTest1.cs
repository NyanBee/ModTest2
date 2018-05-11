using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Wallet;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//Add 800
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 800);
            string lol = "RUB";
            Assert.AreEqual(some.getMoney(lol), 800);

        }

        [TestMethod]
        public void TestMethod2()//Add_400_then_Add_1000_EQUAL_1400
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("RUB", 1000);
            Assert.AreEqual(some.getMoney("RUB"), 1400);

        }

        [TestMethod]
        public void TestMethod3()//Add_Two_Course
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("EUR", 1000);
            Assert.AreEqual(some.getCount(), 2);
        }
    }
}
