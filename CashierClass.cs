using System;
using System.Collections.Generic;
using System.Text;

namespace QueuingApplication
{
    internal class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue = new Queue<string>();

        public CashierClass()
        {
            x = 10000;
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}