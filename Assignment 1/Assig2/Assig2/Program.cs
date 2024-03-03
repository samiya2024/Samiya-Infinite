using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        // Constructor
        public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 0; // Initial balance is set to 0
        }

        // Credit function for deposit
        public void Credit(double depositAmount)
        {
            balance += depositAmount;
        }

        // Debit function for withdrawal
        public void Debit(double withdrawalAmount)
        {
            if (withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        // Display account information
        public void ShowData()
        {
            Console.WriteLine("D->Deposit");
            Console.WriteLine("W->Withdrawal");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
            Console.ReadLine();
        }

        // Getter for TransactionType
        public char TransactionType
        {
            get { return transactionType; }
        }

        // Getter for Amount
        public double Amount
        {
            get { return amount; }
        }
    }

    class Program
    {
        static void Main()
        {
            // Example Usage
            Accounts account = new Accounts(1001, "John Doe", "Savings", 'D', 500.00);

            // Perform deposit
            if (account.TransactionType == 'D')
            {
                account.Credit(account.Amount);
            }
            // Perform withdrawal
            else if (account.TransactionType == 'W')
            {
                account.Debit(account.Amount);
            }

            // Display account information
            account.ShowData();
        }
    }

}