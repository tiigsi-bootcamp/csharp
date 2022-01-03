// Linq: Language Integrated Query.

var names = new List<string>
{
	"Ahmed",
	"Abdillahi",
	"Isra",
	"Ali"
};

var namesWithH = new List<string>();

foreach (var name in names)
{
	if (name.Contains("h"))
	{
		namesWithH.Add(name);
	}
}

Console.WriteLine(namesWithH.Count + " of names have h in them.");

var namesWithD = from name in names
				 where name.Contains("d")
				 select name;

Console.WriteLine(namesWithD.Count() + " of names have D in them.");

var grades = new List<int>(100) { 88, 84, 44, 90, 95 };

var failedGrades = from grade in grades
				   where grade < 50
				   select grade * 2;

Console.WriteLine("Failed grades: " + failedGrades.Count());

var sortedGrades = from grade in grades
				   orderby grade descending
				   select grade;

foreach (var grade in sortedGrades)
{
	Console.WriteLine("Grade: " + grade);
}

var averageGrade = grades.Where(grade => grade >= 50).Average();
Console.WriteLine("Average grade: " + averageGrade);

var sumOfGrades = grades.Sum();
Console.WriteLine("Sum of grades: " + sumOfGrades);

var maxGrade = grades.Max();
Console.WriteLine("Maximum grade: " + maxGrade);

var topTwo = grades.OrderByDescending(grade => grade).Take(2);
foreach (var top in topTwo)
{
	Console.WriteLine("Top: " + top);
}

var gradesExcludingTopTwo = grades.OrderByDescending(grade => grade).Skip(2);
foreach (var grade in gradesExcludingTopTwo)
{
	Console.WriteLine("Non-top-two grades: " + grade);
}

Console.WriteLine("List contains: " + grades.Count);
var passingGrades = grades.OrderByDescending(grade => grade).TakeWhile(grade => grade >= 50);
Console.WriteLine("Passing grades: " + passingGrades.Count());
