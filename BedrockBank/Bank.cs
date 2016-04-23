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

        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName">Name for your account</param>
        /// <param name="ssn">Your social security number</param>
        /// <param name="typeOfAccount">The type of account</param>
        /// <returns>A new account</returns>
        public static Account CreateAccount(string accountName, int ssn, AccountType typeOfAccount)
        {
            var account = new Account
            {
                AccountName = accountName,
                SSN = ssn,
                TypeOfAccount = typeOfAccount
            };

            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }
    }
}
