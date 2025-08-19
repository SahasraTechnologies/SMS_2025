// See https://aka.ms/new-console-template for more information
using SMS.Console;

Console.WriteLine("Hello, World!");

// Using default constructor
User defaultUser = new User(); // Creates a User object with default values
defaultUser.Greet();           // Calls Greet() method to print a message

// Using parameterized constructor
User customUser = new User("Krishna", 30); // Creates a User object with specific values
string greetMessage = customUser.GreetWithReturn(); // Gets greeting message
Console.WriteLine(greetMessage); // Prints the returned message

// Using method with parameters
string customMessage = customUser.GreetWithReturn("Saharsa", "28"); // Calls method with arguments
Console.WriteLine(customMessage); // Prints the returned custom greeting

Console.WriteLine("Press any key to exit..."); // Asks user to press a key before closing
Console.ReadKey(); // Waits for key press to keep console window open
