using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Inherit.Entities
{
    //sealed class SavingsAccount : Account
    class SavingsAccount : Account
    {
        public double interestRate { get; set; }

        public SavingsAccount() {  }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            this.interestRate = interestRate;
        }

        public void UpdateBalance()
        {
            this.Balance += this.Balance * interestRate;
        }

        //public sealed override void Withdraw(double amount)
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            this.Balance -= 2.0;
        }
    }
}
