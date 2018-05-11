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
    }
}
