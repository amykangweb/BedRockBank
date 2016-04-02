using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public enum AccountType
    {
        Savings,
        Checking,
        CD,
        Loans
    }
    /// <summary>
    /// This is about a bank account
    /// for the customer
    /// </summary>
    public class Account
    {
        #region Variables
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Account number for the account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Name of the account
        /// </summary>
        public string AccountName { get; set; }
        public int SSN { get; set; }
        public double Balance { get; private set; }
        public AccountType TypeOfAccount { get; set; }

        #endregion

        #region Constructor
        public Account()
        {
            //lastAccountNumber = lastAccountNumber + 1;
            //AccountNumber = lastAccountNumber;
            AccountNumber = ++lastAccountNumber;
        }
        #endregion

        #region Methods
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        #endregion
    }
}
