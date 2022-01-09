class MyHappyLittleKid<T>
{
	private T[] _toys = new T[0];

	public void Add(T item)
	{
		var count = _toys.Length;
		var oldToys = _toys;

		_toys = new T[count + 1];
		var position = 0;
		foreach (var oldToy in oldToys)
		{
			_toys[position] = oldToy;
			position += 1;
		}

		_toys[count] = item;
	}

	public void PrintAll()
	{
		foreach (var toy in _toys)
		{
			Console.WriteLine($"Toy: {toy}");
		}
	}
}