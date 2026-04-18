using System;
using System.Collections.Generic;

namespace BankApp
{
  class Bank
  {
    private List<Customer> customers = new List<Customer>();

    public void OpenAccount(string customerName, string accountNumber)
    {
      BankAccount account = new BankAccount(accountNumber);
      Customer customer = new Customer(customerName, account);

      customers.Add(customer);

      Console.WriteLine($"Account created for {customerName}");
    }

    public void CloseAccount(string accountNumber)
    {
      customers.RemoveAll(c => c.Account.AccountNumber == accountNumber);
      Console.WriteLine($"Account {accountNumber} closed.");
    }

    public Customer FindCustomer(string accountNumber)
    {
      return customers.Find(c => c.Account.AccountNumber == accountNumber);
    }

    public void Transfer(string fromAcc, string toAcc, decimal amount)
    {
      var sender = FindCustomer(fromAcc);
      var receiver = FindCustomer(toAcc);

      if (sender != null && receiver != null)
      {
        sender.Account.Withdraw(amount);
        receiver.Account.Deposit(amount);

        Console.WriteLine($"Transferred {amount} from {fromAcc} to {toAcc}");
      }
      else
      {
        Console.WriteLine("Account not found!");
      }
    }
  }
}