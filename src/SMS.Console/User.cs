// Defines a namespace called SMS.Console
// ✅ NOTE: A **namespace** is like a container that holds related classes and code.
// It helps organize your code and avoid name conflicts.
namespace SMS.Console
{
    // Declares a class named 'User'
    // ✅ NOTE: A **class** is a blueprint for creating objects.
    // It defines what properties (data) and methods (behavior) an object will have.
    public class User
    {
        public string Name { get; set; } // Declares a property 'Name' of type string
        public int Age { get; set; }     // Declares a property 'Age' of type int

        // ✅ NOTE: These are **auto-implemented properties**.
        // `get` allows reading the value, and `set` allows assigning a value.
        public User() // Default constructor - no parameters
        {
            Name = "Venkat"; // Sets default name
            Age = 35;        // Sets default age
        }

        // ✅ NOTE: A **constructor** is a special method that runs when an object is created.
        // This is the **default constructor** that sets predefined values.

        public User(string name, int age) // Constructor with parameters
        {
            Name = name;
            Age = age;
        }

        // ✅ NOTE: This is a **parameterized constructor**. You can pass custom values when creating the object.

        public void Greet() // Method with no return value
        {
            System.Console.WriteLine($"Hello, {Name}! You are {Age} years old.");
        }

        // ✅ NOTE: This method prints a greeting to the console.
        // `$` is used for **string interpolation** (inserting variables inside strings).

        public string GreetWithReturn() // Method that returns a string
        {
            string result = $"Hello, {Name}! You are {Age} years old.";
            return result;
        }
        // ✅ NOTE: This method builds a greeting message and returns it as a string.

        public string GreetWithReturn(string name, string age) // Overloaded method with input parameters
        {
            string result = $"Hello, {name}! You are {age} years old.";
            return result;
        }
        // ✅ NOTE: This is **method overloading**. It uses parameters to return a custom greeting.
    }
}
