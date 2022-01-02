class BankAccount
{
	public int AccountNumber { get; }

	public string Owner { set; get; }

	public decimal Balance { get; private set; }

	public List<Transaction> Transactions { get; set; } = new List<Transaction>(1_000);

	public BankAccount(int accountNumber, string owner, decimal initialBalance)
	{
		AccountNumber = accountNumber;
		Owner = owner;
		
		Deposit(initialBalance);
	}

	public void Deposit(decimal amount)
	{
		if (amount <= 0)
		{
			return;
		}
		
		Balance += amount;

		var transaction = new Transaction()
		{
			Reference = Transactions.Count + 1,
			Amount = amount,
			Date = DateTime.Now
		};

		Transactions.Add(transaction);
	}

	public void Withdraw(decimal amount)
	{
		if (amount > Balance)
		{
			Console.WriteLine("Ma haysatid lacag kugu filan! 😛");
			return; // Joog! 😂
		}

		Balance -= amount;
		var transaction = new Transaction()
		{
			Reference = Transactions.Count + 1,
			Amount = -amount,
			Date = DateTime.Now
		};

		Transactions.Add(transaction);
	}
}
