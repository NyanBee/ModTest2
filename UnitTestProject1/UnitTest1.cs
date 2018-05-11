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
        public void TestMethod2()//Add 400 then Add 1000 EQUAL 1400
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("RUB", 1000);
            Assert.AreEqual(some.getMoney("RUB"), 1400);

        }

        [TestMethod]
        public void TestMethod3()//Add Two Course
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("EUR", 1000);
            Assert.AreEqual(some.getCount(), 2);
        }

        [TestMethod]
        public void TestMethod4()//Add then watch the list
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("EUR", 1000);
            Assert.AreEqual(some.ToStringList(), "400 RUB,1000 EUR");

        }

        [TestMethod]
        public void TestMethod5()//Converter
        {
            Bank_plus b = new Bank_plus();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("USD", 100);
            some.addMoney("EUR", 100);
            int total = b.convert(100, "USD", "RUB");
            Assert.AreEqual(total, 6000);
        }
    }
}
