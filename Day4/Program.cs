Console.WriteLine("Working with Collections");

var numbers = new[] { 10.5F, 20.5F, 30.5F };

var people = new string[10];
people[0] = "Fatima";
people[1] = "Aisha";
people[9] = "Mohamed";

Console.WriteLine("Please enter a name:");
var name = Console.ReadLine();

people[2] = name;
people[3] = name + " Test";

var counter = people.Length - 1;
while (counter >= 0)
{
	var person = people[counter];
	Console.WriteLine("Person: " + person);

	counter -= 1;
}

// Syntactic sugar!
foreach (var person in people)
{
	Console.WriteLine("Person: " + person);
}

Console.WriteLine("All people: " + people);
