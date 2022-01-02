// Functions.

void SayHello()
{
	Console.WriteLine("Hello there!");
}

SayHello();

int Add(int a, int b)
{
	return a + b;
}

// Expression-Bodied function.

// => Goes to
// => Whereby
int Sub(int a, int b) => a - b;

// Lambda Expressions.
var multiply = (int a, int b) => a * b; // One-liner.

var thing = (int age) => "My age is: " + age;

var divide = (int a, int b) => // Multiple statements.
{
	return a / b;
};

// f(x)

Action<string, string> sayHi = (name, phone) => Console.WriteLine("Hi " + name);

var x = multiply(12, 12);

var result = Add(10, 20);
Console.WriteLine("Result: " + x);

sayHi("Mohamed", "r6789");
