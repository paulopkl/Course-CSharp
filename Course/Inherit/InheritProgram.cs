using System;
using Course.Inherit.Entities;

namespace Course.Inherit
{
    class InheritProgram
    {
        public InheritProgram()
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            //Console.WriteLine(account.Balance);

            //account.Balance = 200;

            //Account account = new Account(1001, "BBrown", 0.0);

            //BusinessAccount bAccount = new BusinessAccount(1002, "Bob B", 0.0, 500.0);

            //// UPCASTING ....Account -> Account | Data Loss
            //Account account1 = bAccount;
            //Account account2 = new BusinessAccount(1003, "Paulo", 0.0, 200.0);
            //Account account3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //// DOWNCASTING

            //BusinessAccount account4 = (BusinessAccount)account2;
            //account4.Loan(100.0);

            //if (account3 is BusinessAccount)
            //{
            //    //BusinessAccount account5 = (BusinessAccount)account3;
            //    BusinessAccount account5 = account3 as BusinessAccount;
            //    account5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (account3 is SavingsAccount)
            //{
            //    SavingsAccount account5 = (SavingsAccount)account3;
            //    account5.UpdateBalance();
            //    Console.WriteLine("Updated!");
            //}

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
