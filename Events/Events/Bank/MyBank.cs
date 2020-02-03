using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Bank
{
    class MyBank
    {
        private string name;
        private int balance;
        public event MessageHandler OnAnyTransaction;
        public event MessageHandler OnMoneyAdded;
        public event MessageHandler OnMoneyConversion;

        public MyBank(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        internal void AddMoney(int amount)
        {
            balance += amount;
            OnAnyTransaction?.Invoke($"Money adding operation engaged.");
            OnMoneyAdded?.Invoke($"Money was added to acocunt {name}. Amount was {amount}. New balance is {balance}.");
            //  if (OnMoneyAdded != null)
            //  {
            //      OnMoneyAdded($"Money was added to acocunt {name}. Amount was {amount}. Balance new is {balance}.");
            //  }

        }

        internal void ConvertToCurrency(int amountToConvert, char currency, float exchangeRate)
        {
            OnAnyTransaction?.Invoke("Money exchange operation was engaged.");
            OnMoneyConversion?.Invoke($"{amountToConvert} was taken from balance to convert to {currency}. Exchange rate was {exchangeRate} and so it makes {amountToConvert * exchangeRate}{currency}");
            
        }
    }
}
