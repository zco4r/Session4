namespace Session4;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        // Call the function
        PrintWelcome(userName);


        // Function definition
        static void PrintWelcome(string name)
        {
            Console.WriteLine($"Hello {name}, welcome! It is great to have you here.");
        }
        
        
    }
}    
