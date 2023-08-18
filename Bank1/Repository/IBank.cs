using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository
{
    internal interface IBank
    {
        public void CreateAccount(string name, AccountType type);
        public List<Account> GetAccounts();
        public void ChargeInterst();
        public decimal Deposit(int accountId, decimal amount);
        public decimal Withdraw(int accountId, decimal amount);
        public decimal Balance(int accountId);
        public decimal BankHolding();
        public string GetBankName();
        public Account FindAccountName(string? accountName);
        public Account FindAccountId(int? accountId);
        public List<AccountListItem> GetAllAcc();
    }
}
