class BankAccount
{
	public int AccountNumber { get; }

	public string Owner { set; get; }

	public decimal Balance { get; private set; }

	public Transaction[] Transactions { get; set; } = new Transaction[0];

	public BankAccount(int accountNumber, string owner, decimal initialBalance)
	{
		AccountNumber = accountNumber;
		Owner = owner;
		Balance = initialBalance;
	}

	public void Deposit(decimal amount)
	{
		Balance += amount;

		var transaction = new Transaction()
		{
			Reference = Transactions.Length + 1,
			Amount = amount,
			Date = DateTime.Now
		};

		var transactionCount = Transactions.Length;
		var oldTransactions = Transactions;

		Transactions = new Transaction[transactionCount + 1];

		// Soo celi xogtii hore.
		var position = 0;
		foreach (var oldTransaction in oldTransactions)
		{
			Transactions[position] = oldTransaction;
			position += 1;
		}

		Transactions[transactionCount] = transaction;
	}

	public void Withdraw(decimal amount)
	{
		if (amount > Balance)
		{
			Console.WriteLine("Ma haysatid lacag kugu filan! 😛");
			return; // Joog! 😂
		}
		
		Balance -= amount;
		amount = -amount;
	}
}