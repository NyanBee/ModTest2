using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Wallet
{
    public class Bank
    {
        public Hashtable course = new Hashtable();
        public Bank()
        {
            //RUB, USD, GBP
            course.Add("RUBUSD", 20);
            course.Add("RUBGPB", 16);
            course.Add("USDRUB", 60000);
            course.Add("USDGPB", 850);
            course.Add("GPBRUB", 70000);
            course.Add("GPBUSD", 1200);
            course.Add("EURRUB", 6000);
        }
    }
}
