using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Wallet
{
    public class Wallet
    {
        public Hashtable wallet = new Hashtable();
        Bank bank;
        public MoneyPrinter printer;
        private Bank b;
        private MoneyPrinter_plus mp;

        public Wallet(Bank bank1, MoneyPrinter printer1)
        {
            bank = bank1;
            printer = printer1;
        }

        public Wallet(Bank b, MoneyPrinter_plus mp)
        {
            // TODO: Complete member initialization
            this.b = b;
            this.mp = mp;
        }

        public void addMoney(string course, int amount)
        {
            if (wallet[course] == null)
            {
                wallet.Add(course, amount);
            }
            else
            {
                wallet[course] = (int)wallet[course] + amount;
            }

            printer.print("Add", course, amount.ToString());
        }

        int remov(string course, int amount)
        {
            if ((int)wallet[course] < amount)
            {
                throw new System.OverflowException();
            }
            else
            {
                return (int)wallet[course] - amount;
            }
        }

        public void removeMoney(string course, int amount)
        {
            try
            {
                wallet[course] = remov(course, amount);

                if ((int)wallet[course] == 0)
                    wallet.Remove(course);
            }
            catch (OverflowException e)
            {
            }
            printer.print("Remove", course, amount.ToString());
        }
    }
}
