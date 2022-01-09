// Understanding Generics.

var area = CalculateSquareArea(new Square(4));

Console.WriteLine($"Area of 4 sided square is: {area}");

var area1 = CalculateRectangleArea(new Rectangle(4, 8));

Console.WriteLine($"Area of 4 * 8 rectangle is: {area1}");

var result = CalculateArea<Square>(new Square(5));
Console.WriteLine($"Area of 5 sided square is: {result}");

var result2 = CalculateArea(new Rectangle(5, 10));
Console.WriteLine($"Area of 5 * 10 rectangle is: {result2}");

int CalculateArea<T>(T shape) where T : class // T = type
{
	var result = shape switch
	{
		Square square => square.Side * square.Side,
		Rectangle rectangle => rectangle.Width * rectangle.Height,
		_ => 0
	};

	// if (shape is Square square)
	// {
	// 	return square.Side * square.Side;
	// }

	// if (shape is Rectangle rectangle)
	// {
	// 	return rectangle.Width * rectangle.Height;
	// }

	return result;
}

int CalculateSquareArea(Square shape)
{
	return shape.Side * shape.Side;
}

int CalculateRectangleArea(Rectangle shape)
{
	return shape.Height * shape.Width;
}

var myLittleList = new MyHappyLittleKid<string>();
myLittleList.Add("Polic Car");
myLittleList.Add("Race Car");
myLittleList.PrintAll();


var myLittleList2 = new MyHappyLittleKid<int>();
myLittleList2.Add(1);
myLittleList2.Add(1000);

myLittleList2.PrintAll();
