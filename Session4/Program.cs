namespace Session4;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Personalized Welcome Function
        void PrintWelcome(string name)
        {
            Console.WriteLine($"Hello {name}, welcome to the program!");
        }

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        PrintWelcome(userName);
        
        
        //Task 2 - Square Number Function
        int Square(int number)
        {
            return number * number;
        }
        
        Console.Write("Enter an integer to square: ");
        int num = int.Parse(Console.ReadLine());
        int result = Square(num);
        Console.WriteLine($"The square is: {result}");
        
        
        //Task 3 - Celsius to Fahrenheit Function
        double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        Console.Write("Enter temperature in Celsius: ");
        double c = double.Parse(Console.ReadLine());
        double f = CelsiusToFahrenheit(c);
        Console.WriteLine($"Temperature in Fahrenheit: {f}");
        
        //Task 4 - Fixed Menu Display Function
        void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        DisplayMenu();

        //Task 3: Celsius to Fahrenheit Function
        double celsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        Console.Write("Enter temperature in Celsius: ");
        double a = double.Parse(Console.ReadLine());
        double b = CelsiusToFahrenheit(a);
        Console.WriteLine($"Temperature in Fahrenheit: {b}");
    }
}    
