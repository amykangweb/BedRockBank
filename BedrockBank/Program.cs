using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Account
            var account1 = new Account();
            account1.AccountName = "My checking";
            account1.TypeOfAccount = AccountType.Checking;
            var newBalance = account1.Deposit(300.00);
            Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of account: {2}, Balance: {3:c}", 
                account1.AccountName, account1.AccountNumber, account1.TypeOfAccount, account1.Balance);

            // Creating an instance of Account
            var account2 = new Account();
            account2.AccountName = "My savings";
            account2.TypeOfAccount = AccountType.Savings;
            account2.Deposit(200.00);
            Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of account: {2}, Balance: {3:c}",
                account2.AccountName, account2.AccountNumber, account2.TypeOfAccount, account2.Balance);
        }
    }
}
