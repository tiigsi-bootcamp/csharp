class BankAccount
{
	public int AccountNumber { get; }

	public string Owner { set; get; }

	public decimal Balance { get; private set; }

	public BankAccount(int accountNumber, string owner, decimal initialBalance)
	{
		AccountNumber = accountNumber;
		Owner = owner;
		Balance = initialBalance;
	}

	public void Deposit(decimal amount)
	{
		Balance += amount;
	}

	public void Withdraw(decimal amount)
	{
		if (amount > Balance)
		{
			Console.WriteLine("Ma haysatid lacag kugu filan! 😛");
			return; // Joog! 😂
		}
		
		Balance -= amount;
	}
}