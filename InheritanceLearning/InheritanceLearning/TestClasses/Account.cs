using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Account
    {
        DateTime lastOperationDate;
        decimal balance;
        decimal creditAllowed;
        decimal bigestWithdrawal;

        public Account(DateTime lastOperationDate, decimal balance, decimal creditAllowed, decimal largestWithdrawal) {
            this.lastOperationDate = lastOperationDate;
            this.balance = balance;
            this.bigestWithdrawal = bigestWithdrawal;
            this.creditAllowed = creditAllowed;
        }
        public void PutMoney(decimal amount)
        {
            balance += amount;
            lastOperationDate = DateTime.Now;
        }
        public void TakeMoney(decimal amount)
        {
            if (amount < balance)
            {
            lastOperationDate = DateTime.Now;
            balance -= amount;
            bigestWithdrawal = bigestWithdrawal < amount ? amount : bigestWithdrawal;
            }
            else
            {
                Console.WriteLine("Issuficient funds");
            }
        }

    }
}
