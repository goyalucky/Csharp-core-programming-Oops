using System;

class Program
{
	static void Main(string[] args)
	{
		Bank sbi = new Bank("State Bank of India");

		Customer cust1 = new Customer("Prashant");
		Customer cust2 = new Customer("Aman");

		sbi.OpenAccount(cust1, 101, 5000);
		sbi.OpenAccount(cust1, 102, 10000);
		sbi.OpenAccount(cust2, 201, 7000);

		cust1.ViewBalance();
		cust2.ViewBalance();
	}
}
