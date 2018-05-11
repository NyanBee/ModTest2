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
    }
}
