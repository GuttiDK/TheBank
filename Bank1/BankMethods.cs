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
        public string _bankName;
        int _idCounter;
        List<Account> _accounts;

        public BankMethods(string name)
        {
            _bankName = name;
            _accounts = new List<Account>();
        }



        public void CreateAccount(string name)
        {
            _accounts.Add(new Account { Id = _idCounter++, Name = name, Balance = 0 });
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

        public decimal Deposit(Account account, decimal amount)
        {
            account.Balance += amount;
            return account.Balance;
        }

        public decimal Withdraw(Account account, decimal amount)
        {
            account.Balance -= amount;
            return account.Balance;
        }

        public decimal Balance(Account account)
        {
            return account.Balance;
        }

    }
}
