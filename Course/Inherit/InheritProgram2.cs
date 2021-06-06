﻿using System;
using System.Collections.Generic;
using Course.Inherit.Entities;

namespace Course.Inherit
{
    class InheritProgram2
    {
        public InheritProgram2()
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Paulo", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new BusinessAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total Balance: {sum.ToString("F2")}");

            foreach (Account acc in list)
            {
                acc.Withdraw(10);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2")}");
            }
        }
    }
}
