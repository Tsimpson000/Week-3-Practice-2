using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_Virtual_override
{
    internal class Saving : BankAccount
    {
        double _interest;

        public Saving(string name, string accountNumber, double balance, double interest = .05) : base(name, accountNumber, balance)
        {
            _interest = interest;
        }
        //public override void Deposit(double amount)
        //{
        //    base.Deposit(amount);
        //    Balance += (amount * _interest);
        //}
        public override bool Deposit(double amount)
        {
            bool depositAmount = Deposit(amount);
            if (depositAmount)
            {
                Balance += _interest;
            }

            return depositAmount;
        }

        public override bool Withdraw(double amount)
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
    }
}
