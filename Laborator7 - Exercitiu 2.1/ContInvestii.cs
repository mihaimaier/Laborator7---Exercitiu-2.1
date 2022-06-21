using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7___Exercitiu_2._1
{
    class ContInvestii
    {
        private decimal _balance;
        private int _termenGiven;
        private int _termenInput;

        // Constructor
        public ContInvestii()
        {
            _balance = 0;
            _termenGiven = 0;
            _termenInput = 0;

        }

        // Constructor (overloaded constructor)
        public ContInvestii(decimal startingBalance, int termenGiven, int termenInput)
        {
            _balance = startingBalance;
            _termenGiven = termenGiven;
            _termenInput = termenInput;
        }

        // Balance property (read-only)
        public decimal Balance
        {
            get { return _balance; }
        }

        public int TermenDat
        {
            get { return _termenGiven; }
        }

        public int TermenInput
        {
            get { return _termenInput; }
        }

        public void Print()
        {
            Console.WriteLine($"Soldul curent este: {_balance}");
        }

        // Withdraw method
        public void Withdraw(decimal amount, int termenInput, int termenGiven)
        {
            _termenInput = termenInput;
            _termenGiven = termenGiven;

            if (termenInput < termenGiven)
            {
                Console.WriteLine("Termenul nu a fost atins! Nu puteti sa extrageti bani!");
                Console.WriteLine($"Soldul este: {_balance}");
            }

            else
            {
                Console.WriteLine("Termenul a fost atins!");
                Console.WriteLine($"Soldul este: {_balance -= amount}");
            }
        }
    }
}
