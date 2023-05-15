using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_Virtual_override
{
    internal class BankAccount
    {
        string _name;
        string _accountNumber;
        double _balance;

        public BankAccount(string name, string accountNumber, double balance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
        }
        public string Name { get => _name; set => _name = value; }
        public string AccountNumber { get => _accountNumber; protected set => _accountNumber = value; }
        public double Balance { get => _balance; protected set => _balance = value; }

        public virtual bool Deposit(double amount)
        {
            if(IsAmountPositive(amount))
            {
                _balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool Withdraw(double amount)
        {
            if ((IsAmountPositive(amount)) && CheckBalance(amount))
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool IsAmountPositive(double amount)
        {
            return amount > 0;
        }
        private bool CheckBalance(double amount)
        {
            return amount <= _balance;
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {_name} - {_accountNumber} - {_balance}";
        }
    }
}
