using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1.Models
{
    public abstract class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public AccountType Type { get; set; }
        public decimal InterestRate { get; set; }

        public abstract void CalculateInterest();
    }

    public class Checking : Account
    { 
        public override void CalculateInterest()
        {
            InterestRate = 1.005M;
            Balance *= InterestRate;
        }
        public Checking()
        {
            Type = AccountType.Checking;
        }
    }

    public class Savings : Account
    {
        public override void CalculateInterest()
        {
            if (Balance <= 100000)
            {
                if (Balance <= 50000)
                {
                    InterestRate = 1.01M;
                    Balance *= InterestRate;
                }

                else
                {
                    InterestRate = 1.02M;
                    Balance *= InterestRate;
                }
            }
            else
            {
                InterestRate = 1.03M;
                Balance *= InterestRate;
            }
        }

        public Savings()
        {
            Type = AccountType.Savings;
        }
    }

    public class Consumer : Account
    {
        public override void CalculateInterest()
        {
            if (Balance > -1)
            {
                InterestRate = 1.001M;
                Balance *= InterestRate;
            }
            else
            {
                InterestRate = 1.2M;
                Balance *= InterestRate;
            }
        }
        public Consumer()
        {
            Type = AccountType.Consumer;
        }
    }
}
