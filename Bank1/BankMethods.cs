using Bank1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    public class BankMethods
    {
        readonly string _bankName;
        int _idCounter;
        decimal _bankbalance;
        List<Account> _accounts;

        public BankMethods(string name)
        {
            _bankName = name;
            _bankbalance = 0;
            _accounts = new List<Account>();
        }



        public void CreateAccount(string name, AccountType type)
        {
            switch (type)
            {
                case AccountType.Checking:
                    _accounts.Add(new Checking { Id = ++_idCounter, Name = name, Type = type });
                    break;
                case AccountType.Savings:
                    _accounts.Add(new Savings { Id = ++_idCounter, Name = name, Type = type });
                    break;
                case AccountType.Consumer:
                    _accounts.Add(new Consumer { Id = ++_idCounter, Name = name, Type = type });
                    break;
                default:
                    throw new Exception("Invalid account type");
            }
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

        public void ChargeInterst()
        {
            foreach (Account account in _accounts)
            {
                account.CalculateInterest();
            }
        }

        public decimal Deposit(int accountId, decimal amount)
        {
            _bankbalance += amount;
            return _accounts.First(x => x.Id == accountId).Balance += amount;
        }

        public decimal Withdraw(int accountId, decimal amount)
        {
            _bankbalance -= amount;
            return _accounts.First(x => x.Id == accountId).Balance -= amount;
        }

        public decimal Balance(int accountId)
        {
            return _accounts.First(x => x.Id == accountId).Balance;
        }

        public string GetBankName()
        {
            return _bankName;
        }

        public Account FindAccountName(string? accountName)
        {
            if (accountName != null)
            {
                return _accounts.First(x => x.Name == accountName);
            }
            else
            {
                throw new Exception("No account found");
            }
        }

        public Account FindAccountId(int? accountId)
        {
            if (accountId != null)
            {
                return _accounts.First(x => x.Id == accountId);
            }
            else
            {
                throw new Exception("No account found");
            }
        }
    }
}
