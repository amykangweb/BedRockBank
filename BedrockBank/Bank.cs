using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class Bank
    {
        #region Variables
        public static BankModel db = new BankModel();
        #endregion

        // Find if customer exists in db.
        public static Customer FindCustomer(string emailAddress)
        {
            if(string.IsNullOrEmpty(emailAddress)) 
            {
                throw new ArgumentNullException("Email address cannot be empty.");
            }
            // Return first record or returns NULL
            return db.Customers.Where(c => c.CustomerEmail == emailAddress).FirstOrDefault();
        }

        public static Customer CreateCustomer(string name, string emailAddress)
        {
            var customer = new Customer
            {
                CustomerName = name,
                CustomerEmail = emailAddress
            };

            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }

        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName">Name for your account</param>
        /// <param name="ssn">Your social security number</param>
        /// <param name="typeOfAccount">The type of account</param>
        /// <returns>A new account</returns>
        public static Account CreateAccount(string accountName, int ssn, AccountType typeOfAccount, Customer customer)
        {
            var account = new Account
            {
                AccountName = accountName,
                SSN = ssn,
                TypeOfAccount = typeOfAccount,
                Customer = customer
            };

            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public static Account[] GetAllAccounts(string emailAddress)
        {
            return db.Accounts.Where(a => a.Customer.CustomerEmail == emailAddress).ToArray();
        }

        public static Account FindAccountByAccountNumber(int number)
        {
            return db.Accounts.Where(a => a.AccountNumber == number).FirstOrDefault();
        }
    }
}
