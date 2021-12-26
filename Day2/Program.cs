
// Strings.

var person = "   Jamila Hassan         ";

person = person.TrimEnd();
person = person.TrimStart();

var name = "    Ahmed    Ali     ".Trim();

var personName = "Naima     Ali ";
personName = personName.Replace("Naima", "Anab");

Console.WriteLine("Name: '" + person + "'");
Console.WriteLine("Name: '" + name + "'");
Console.WriteLine("Name: '" + personName + "'");

var lyric = "The older I get, the harder I fall!";

var result = lyric.Contains("older");
Console.WriteLine("Contains 'elder':" + result);

result = lyric.StartsWith("The");
Console.WriteLine("Starts with 'The':" + result);

Console.WriteLine("Total chars: " + lyric.Length);
