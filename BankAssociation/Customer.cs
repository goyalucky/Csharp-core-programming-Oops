/*Bank and Account Holders (Association)
Description: Model a relationship where a Bank has Customer objects associated with it. A
Customer can have multiple bank accounts, and each account is linked to a Bank.
Tasks:
● Define a Bank class and a Customer class.
● Use an association relationship to show that each Customer has an account in a Bank.
● Implement methods that enable communication, such as OpenAccount() in the Bank class and ViewBalance() in the Customer class.
Goal: Illustrate association by setting up a relationship between customers and the bank.*/


using System;
using System.Collections.Generic;

class Customer
{
	public string Name { get; set; }
	public List<Account> Accounts { get; set; }

	public Customer(string name)
	{
		Name = name;
		Accounts = new List<Account>();
	}

	public void AddAccount(Account account)
	{
		Accounts.Add(account);
	}

	public void ViewBalance()
	{
		Console.WriteLine($"\nCustomer: {Name}");
		foreach (Account acc in Accounts)
		{
			Console.WriteLine($"Account No: {acc.AccountNumber}, Balance: {acc.Balance}");
		}
	}
}
