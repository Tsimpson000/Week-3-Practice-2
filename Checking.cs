using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_Virtual_override
{
    internal class Checking : BankAccount
    {
        double _overdraftFee;

        public Checking(string name, string accountNumber, double balance, double overdraftFee = 50) : base(name, accountNumber, balance)
        {
            OverdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        public override bool Withdraw(double amount)
        {
            bool withdrewAmount = base.Withdraw(amount);
            if(!withdrewAmount)
            {
                Balance -= OverdraftFee;
            }

            return withdrewAmount;
        }
    }
}
