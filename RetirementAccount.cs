using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_Virtual_override
{
    internal class RetirementAccount : Saving
    {
        public RetirementAccount(string name, string accountNumber, double balance, double interest = 0.05) : base(name, accountNumber, balance, interest)
        {
        }
        //public bool Withdraw()
        //{
        //    bool errorMsg = false;


        //}
    }
}
