using System;

namespace BankApp
{
  class Program
  {
    public static object Shohjahon { get; private set; }

    static void Main(string[] args)
    {
      Bank bank = new Bank();

      // Create customers
      bank.OpenAccount("Ali", "1001");
      bank.OpenAccount("Vali", "1002");

      // Deposit money
      var ali = bank.FindCustomer("1001");
      ali.Account.Deposit(1000);

      var vali = bank.FindCustomer("1002");
      vali.Account.Deposit(500);



      // Transfer money
      bank.Transfer("1001", "1002", 300);

      // Show balances
      Console.WriteLine($"Ali balance: {ali.Account.GetBalance()}");
      Console.WriteLine($"Vali balance: {vali.Account.GetBalance()}");

      Console.ReadLine();
    }
  }
}