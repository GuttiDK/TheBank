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
        List<Account> _accounts;

        public BankMethods(string name)
        {
            _bankName = name;
            _accounts = new List<Account>();
        }



        public Account CreateAccount(string name)
        {
            Account account = new Account(name, ++_idCounter);
            _accounts.Add(account);
            return account;
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

        public decimal Deposit(int accountId, decimal amount)
        {
            return _accounts.First(x => x.Id == accountId).Balance += amount;
        }

        public decimal Withdraw(int accountId, decimal amount)
        {
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
