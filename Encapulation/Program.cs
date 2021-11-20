using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Encapulation
{
    class Account
    {
        private static double balance = 100;

        public static double GetBalance()
        {
            return balance;
        }
        public static void SetBalance(double amount)
        {
            if (amount < 0)
                balance = balance + amount;
            else
                Console.WriteLine("Please enter an amount of more than 1 Ruppes");
        }
    }
}