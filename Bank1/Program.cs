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

            string accountName = "";
            int accountId = 0;
            decimal amount = 0;

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
                            accountName = InputString("Insert name: ");
                            bank.CreateAccount(accountName);
                            Console.Clear();
                            Console.WriteLine(bank.GetBankName());
                            Menu();
                            Console.WriteLine($"Account created: \n Id: {bank.FindAccountName(accountName).Id}\n Name: {bank.FindAccountName(accountName).Name}\n Balance: {bank.FindAccountName(accountName).Balance}");
                            Console.ReadKey();
                            break;
                        case "d":
                            accountId = InputInt("Insert account ID: ");
                            amount = InputDecimal("Insert amount: ");
                            bank.Deposit(accountId, amount);
                            Console.Clear();
                            Console.WriteLine(bank.GetBankName());
                            Menu();
                            Console.WriteLine($"Account: \n Name: {bank.FindAccountId(accountId).Name}\n Balance: {bank.FindAccountId(accountId).Balance}");
                            Console.ReadKey();
                            break;
                        case "w":
                            accountId = InputInt("Insert account ID: ");
                            amount = InputDecimal("Insert amount: ");
                            bank.Withdraw(accountId, amount);
                            Console.Clear();
                            Console.WriteLine(bank.GetBankName());
                            Menu();
                            Console.WriteLine($"Account: \n Name: {bank.FindAccountId(accountId).Name}\n Balance: {bank.FindAccountId(accountId).Balance}");
                            Console.ReadKey();
                            break;
                        case "s":
                            accountId = InputInt("Insert account ID: ");
                            bank.Balance(accountId);
                            Console.Clear();
                            Console.WriteLine(bank.GetBankName());
                            Menu();
                            Console.WriteLine($"Account: \n Name: {bank.FindAccountId(accountId).Name}\n Balance: {bank.FindAccountId(accountId).Balance}");
                            Console.ReadKey();
                            break;
                        case "b":
                            ListAccounts(bank);
                            Console.ReadKey();
                            break;
                        case "x":
                            runTime = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input");
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
        /// Show menu
        /// </summary>
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
            Console.WriteLine("| x = Exit                         |");
            Console.WriteLine(" ----------------------------------");
        }



        /// <summary>
        /// Writeline and readline returning list
        /// </summary>
        /// <param name="text"></param>
        /// <returns>list</returns>
        public static void ListAccounts(BankMethods bank)
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
                    Console.WriteLine($"Name: {item.Name} ID: {item.Id} Balance: {item.Balance}");
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
