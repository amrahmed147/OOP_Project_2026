using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    public class SavingAccount : Account
    {
        public decimal InterestRate { get; private set; }
        private int lastInterestApplied;
        public SavingAccount(Client owner, decimal interestRate) : base(owner,AccountType.Saving)
        {
            InterestRate = interestRate;
            lastInterestApplied = DateTime.Now.Month;
        }
        public void ApplyInterest()
        {
            int currentMonth = DateTime.Now.Month;
            decimal interest = Balance * InterestRate;
            if (currentMonth != lastInterestApplied)
            {
                Balance += interest;
                history.Add($"Interest applied: {interest} EGP on {DateTime.Now}");
                lastInterestApplied = currentMonth;
            }
        }
    }
}