using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank1;
using Bank1.Models;

namespace Bank1
{
    class Program
    {
        public static void Main()
        {
            BankMethods bank = new BankMethods("Bank of America");
            bank.CreateAccount("John Doe");
            List<Account> test = bank.GetAccounts();
            Account Account = test[0];

            Console.WriteLine($"Welcome to the {bank._bankName}");
            Console.WriteLine($"Acount created {Account.Name} and balance is {Account.Balance} kr.");
            Console.WriteLine($"Deposit: 300 kr. Balance: {bank.Deposit(Account, 300)} kr.");
            Console.WriteLine($"Witdraw: 100 kr. Balance: {bank.Withdraw(Account, 100)} kr.");
            Console.WriteLine($"Balance: {bank.Balance(Account)} kr.");

        }
    }
}