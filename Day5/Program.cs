// Accounts: Number, Owner, Balance, Transactions
// Deposit
// Withdrawal

// Transaction: Reference, Amount, Date

var account1 = new BankAccount(1, "Test Owner", 10.5M);

account1.Deposit(90);

Console.WriteLine("Owner: " + account1.Owner);
Console.WriteLine("Account: " + account1.AccountNumber + " has balance of: " + account1.Balance.ToString("C"));

account1.Withdraw(1000);

Console.WriteLine("Account: " + account1.AccountNumber + " has balance of: " + account1.Balance.ToString("C"));
