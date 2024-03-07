using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{ 
 class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

public class BankingSystem
{
    private decimal balance = 0;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance for withdrawal.");
        }

        balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankingSystem bank = new BankingSystem();

        Console.WriteLine("Welcome to our banking system!");

       
        Console.WriteLine("Enter the amount you want to deposit:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        bank.Deposit(depositAmount);
        Console.WriteLine($"Successfully deposited {depositAmount}.");

       
        Console.WriteLine("Enter the amount you want to withdraw:");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());

        try
        {
            bank.Withdraw(withdrawalAmount);
            Console.WriteLine($"Successfully withdrawn {withdrawalAmount}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Argument Exception: " + ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Insufficient Funds Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occurred: " + ex.Message);
        }

       
        Console.WriteLine($"Current balance: {bank.GetBalance()}");

        Console.ReadLine();
    }
   }

}

/*
 Welcome to our banking system!
Enter the amount you want to deposit:
6000
Successfully deposited 6000.
Enter the amount you want to withdraw:
2000
Successfully withdrawn 2000.
Current balance: 4000 */