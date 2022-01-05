// String Interpolation.
// Pattern Matching.

var firstName = "Ahmed";
var lastName = "Ali";

var fullName = $"{firstName} {lastName}";
var salary = 1200.5M;

Console.WriteLine($"Full Name: {fullName} salary: {salary:C4}");

var salaries = new List<int> { 500, 800, 1_200, 1_450, 2_000, 1_500 };

// 1000 - 1500

if (salary >= 1_000 && salary <= 1_500)
{
	Console.WriteLine($"{salary} is between 1000 - 1500");
}

if (salary is >= 1_000 and <= 1_500)
{
	Console.WriteLine($"{salary} is between 1000 - 1500");
}

var goodSalaries = salaries
	.Where(salary => salary is >= 1_000 and <= 1_500);

foreach (var goodSalary in goodSalaries)
{
	Console.WriteLine($"Good salary: {goodSalary}");
}

var word = "neat work";
var message = word switch
{
	"nice" or "great" or "good" => "Good word",
	"bad" => "Not a good word",
	_ when word.Length > 5 => "Ma aha hal erey",
	_ => "Ma qiyaasi karo",
};

Console.WriteLine(message);