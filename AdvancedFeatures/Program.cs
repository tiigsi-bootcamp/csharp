// Tuples
// Records
// Pattern Matching.

var x = 10;
var y = 20;

(x, y) = (y, x);

Console.WriteLine("X : " + x);
Console.WriteLine("Y : " + y);

// Destructuring.
var (a, b) = Calculate();

Console.WriteLine("Calculate: " + a + " iyo " + b);

(int value, int value2) Calculate()
{
	return (10, 10);
}

var newStudent = new Student(1, "Ahmed", "65", "Male", "Somewhere");

newStudent = newStudent with
{
	Phone = "659001440",
	Address = "150 Street"
};

Console.WriteLine(newStudent.Name + "'s Phone: " + newStudent.Phone);