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

            string accountName = "";
            int accountId = 0;
            decimal amount = 0;
            string runBack = "Press any key to return to menu";

            bool runTime = true;
            while (runTime == true)
            {
                Console.Clear();
                Console.WriteLine(bank.GetBankName());
                Menu();
                try
                {
                    switch (InputString("Insert here: "))
                    {
                        case "m":
                            break;
                        case "c":
                            MenuFix(bank);
                            accountName = InputString("Insert name: ");
                            bank.CreateAccount(accountName, CreateAccountMenu());
                            MenuFix(bank);
                            Console.WriteLine($"Account created: \n Id: {bank.FindAccountName(accountName).Id}\n Name: {bank.FindAccountName(accountName).Name}\n Type: {bank.FindAccountName(accountName).Type}");
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                        case "d":
                            MenuFix(bank);
                            accountId = InputInt("Insert account ID: ");
                            amount = InputDecimal("Insert amount: ");
                            bank.Deposit(accountId, amount);
                            MenuFix(bank);
                            Console.WriteLine($"Account: \n Name: {bank.FindAccountId(accountId).Name}\n Balance: {bank.FindAccountId(accountId).Balance}");
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                        case "w":
                            MenuFix(bank);
                            accountId = InputInt("Insert account ID: ");
                            amount = InputDecimal("Insert amount: ");
                            bank.Withdraw(accountId, amount);
                            MenuFix(bank);
                            Console.WriteLine($"Account: \n Name: {bank.FindAccountId(accountId).Name}\n Balance: {bank.FindAccountId(accountId).Balance}");
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                        case "s":
                            MenuFix(bank);
                            accountId = InputInt("Insert account ID: ");
                            bank.Balance(accountId);
                            MenuFix(bank);
                            Console.WriteLine($"Account: \n Name: {bank.FindAccountId(accountId).Name}\n Balance: {bank.FindAccountId(accountId).Balance}");
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                        case "b":
                            MenuFix(bank);
                            ListAccounts(bank); ;
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                        case "i":
                            MenuFix(bank);
                            ListAccountType(bank);
                            bank.ChargeInterst();
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                        case "x":
                            runTime = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            Console.WriteLine($"{runBack}");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }

        }

        /// <summary>
        /// Writeline returning a menu
        /// </summary>
        /// <param name="bankmenu"></param>
        /// <returns>menu</returns>
        public static void Menu()
        {
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("| You can chose the following:     |");
            Console.WriteLine("| m = Menu                         |");
            Console.WriteLine("| c = Create account               |");
            Console.WriteLine("| d = Deposit amount               |");
            Console.WriteLine("| w = Withdraw amount              |");
            Console.WriteLine("| s = Show balance                 |");
            Console.WriteLine("| b = Show bank                    |");
            Console.WriteLine("| i = Show interest                |");
            Console.WriteLine("| x = Exit                         |");
            Console.WriteLine(" ----------------------------------");
        }

        /// <summary>
        /// Clear and writeline returning the bankmenu
        /// </summary>
        /// <param name="bankmenu2"></param>
        /// <returns>menu</returns>
        public static void MenuFix(BankMethods bank)
        {
            Console.Clear();
            Console.WriteLine(bank.GetBankName());
            Menu();
        }

        /// <summary>
        /// Writeline and readline returning a accounttype
        /// </summary>
        /// <param name="text"></param>
        /// <returns>list</returns>
        public static AccountType CreateAccountMenu()
        {
            do
            {
                switch (InputInt("1 = Checking\n2 = Savings\n3 = Costumer \nInsert accounttype: "))
                {
                    case 1:
                        return AccountType.Checking;
                    case 2:
                        return AccountType.Savings;
                    case 3:
                        return AccountType.Consumer;
                    default:
                        break;
                }
            } while (true);
        }


        /// <summary>
        /// Writeline and readline returning list of accounts
        /// </summary>
        /// <param name="text"></param>
        /// <returns>list</returns>
        public static void ListAccounts(BankMethods bank)
        {
            decimal bankbalance = 0;
            if (bank.GetAccounts().Count == 0)
            {
                Console.WriteLine("No accounts");

                return;
            }
            else
            {
                Console.WriteLine("Accounts:");

                foreach (var item in bank.GetAccounts())
                {
                    Console.WriteLine($"Name: {item.Name} ID: {item.Id} Balance: {item.Balance}");
                    bankbalance += item.Balance;
                }
                Console.WriteLine($"Bankens beholdning er på {bank} kr.");
            }
        }

        /// <summary>
        /// Writeline and readline returning list of account types
        /// </summary>
        /// <param name="text"></param>
        /// <returns>list</returns>
        public static void ListAccountType(BankMethods bank)
        {
            if (bank.GetAccounts().Count == 0)
            {
                Console.WriteLine("No accounts");

                return;
            }
            else
            {
                Console.WriteLine("Accounts:");

                foreach (var item in bank.GetAccounts())
                {
                    Console.WriteLine($"Name: {item.Name} ID: {item.Id} Type: {item.Type}");
                }
            }
        }

        /// <summary>
        /// Input vaules
        /// </summary>

        /// <summary>
        /// Writeline and readline returning string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string</returns>
        static string InputString(string text)
        {
            while (true)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                if (input.Length > 0)
                    return input;
            }
        }

        /// <summary>
        /// Writeline and readline returning int
        /// </summary>
        /// <param name="text"></param>
        /// <returns>int</returns>
        static int InputInt(string text)
        {
            int value;
            while (true)
            {
                Console.Write(text);
                try
                {
                    return value = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Writeline and readline returning only demical
        /// </summary>
        /// <param name="text"></param>
        /// <returns>demical</returns>
        static decimal InputDecimal(string text)
        {
            decimal value;
            while (true)
            {
                Console.Write(text);
                try
                {
                    return value = Convert.ToDecimal(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}
