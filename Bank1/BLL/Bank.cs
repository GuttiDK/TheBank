using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.BLL
{
    public class Bank
    {
        public Account Account { get; set; }
        public string BankName { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public decimal BankBalance { get; set; }
        public int AccountNumberCounter { get; set; }

        public Bank(List<Account> accounts, decimal bankBalance)
        {
            Accounts = accounts;
            BankBalance = bankBalance;
        }
    }
}

