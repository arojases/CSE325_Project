Console.WriteLine("Hello World");

Console.Write("Hola ");
Console.Write("sin ");
Console.Write("salto");
Console.WriteLine("\n");

/*Console.WriteLine("What is your favorite color? ");
string favoritecolor = Console.ReadLine();
Console.WriteLine("Your favorite color is: " + favoritecolor);
Console.WriteLine("\n");*/

string first = "Hello";
string last = "world";
string message = first + ", " + last + "!";
Console.WriteLine(message);
Console.WriteLine("\n");

/*Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
string greetings=$"Hello {name.ToUpper()}, Welcome!";
Console.WriteLine(greetings);*/

// Exercise 1

// Display a welcome message
Console.WriteLine("Welcome to the greeting program!");

// Ask for the user's name
Console.Write("What is your name? ");
string name = Console.ReadLine();

// Display a personalized greeting
Console.WriteLine($"Hello, {name.ToUpper()}! It's great to meet you.");

Console.WriteLine("\n");

// Exercise 2

// Ask for the user's name
Console.Write("What is your name? ");
string name2 = Console.ReadLine();

// Ask for the user's age
Console.Write("What is your age? ");
string age = Console.ReadLine();
 
// Display a personalized message that includes both pieces of information
Console.WriteLine($"Hello, {name2.ToUpper()}! You are {age} years old.");