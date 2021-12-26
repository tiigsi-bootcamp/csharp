Console.WriteLine("Working with Branching!");

// Branching.

var lyric = "Dugsi ma laha qabyaaladi, waxay dumiso mooyaane.";

if (lyric.Contains("Qabyaalad", StringComparison.OrdinalIgnoreCase))
{
	Console.WriteLine("Whoa, qabyaaladi waa jidhaa!");
}
else if (lyric.Contains("Qaad"))
{
	Console.WriteLine("Qaad is bad!");
}
else
{
	Console.WriteLine("Ma jidho!");
}

// switch statements.
// switch (lyric)
// {
// 	case "test":
// 		Console.WriteLine("Testing");
// 		break;
// 	case "none":
// 		Console.WriteLine("None");
// 		break;
// 	default:
// 		Console.WriteLine("I don't know!!!");
// 		break;
// }

// Switch expressions!
var number1 = 10;
var number2 = 20;
var operation = '%';

var result = 0;

// if (operation != '+')
// {
// 	result  = number1 + number2;
// }
// else if (operation == '-')
// {
// 	result = number1 - number2;
// }
// else
// {
// 	result = 0;
// }

result = operation switch
{
	'+' => number1 + number2,
	'-' => number1 - number2,
	'*' => number1 * number2,
	'/' => number1 / number2,
	'%' => number1 % number2,
	_ => 0
};

Console.WriteLine("Result: " + result);

var isAxad = DateTime.Today.DayOfWeek == DayOfWeek.Sunday;

var message = isAxad switch
{
	true => "Yayy, maanta waa Axad!",
	false => "Maanta ma aha Axad",
};

Console.WriteLine(message);