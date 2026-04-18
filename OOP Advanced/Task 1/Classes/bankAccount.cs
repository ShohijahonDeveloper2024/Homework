using System;

namespace BankApp
{
  class BankAccount
  {
    public string AccountNumber { get; set; }
    private decimal Balance { get; set; }

    public BankAccount(string accountNumber)
    {
      AccountNumber = accountNumber;
      Balance = 0;
    }

    public void Deposit(decimal amount)
    {
      if (amount > 0)
      {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}");
      }
    }

    public void Withdraw(decimal amount)
    {
      if (amount > 0 && amount <= Balance)
      {
        Balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
      }
      else
      {
        Console.WriteLine("Insufficient balance!");
      }
    }

    public decimal GetBalance()
    {
      return Balance;
    }
  }
}