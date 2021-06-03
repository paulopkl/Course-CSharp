using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class AccountBank
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public AccountBank(int number, string holder)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = 0.0;
        }

        public AccountBank(int number, string holder, double balance) : this(number, holder) {
            this.Balance = balance;
        }

        public void Deposit(double quantity)
        {
            this.Balance += quantity;
        }

        public void WithDraw(double quantity)
        {
            this.Balance -= quantity;
        }

        public override string ToString()
        {
            return $"Account: {this.Number}, Holder: {this.Holder}, Balance: " +
                $"R$ {this.Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
