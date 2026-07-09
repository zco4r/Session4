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
        
        //Task 5: Even or Odd Function

        bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        if (IsEven(input))
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
        
        //Task 6: Rectangle Area & Perimeter Functions
        double CalculateArea(double length, double width)
        {
            return length * width;
        }

        double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        Console.Write("Enter length: ");
        double l = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double w = double.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {CalculateArea(l, w)}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter(l, w)}");
        
        //Task 7: Grade Letter Function
        
        string GetGradeLetter(int score)
        {
            if (score >= 90) return "A";
            else if (score >= 80) return "B";
            else if (score >= 70) return "C";
            else if (score >= 60) return "D";
            else return "F";
        }

        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine());
        string grade = GetGradeLetter(score);
        Console.WriteLine($"Your grade is: {grade}");
        
        //Task 8: Countdown Function
        
        void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        Console.Write("Enter starting number: ");
        int startNum = int.Parse(Console.ReadLine());
        Countdown(startNum);
        
        //Task 9: Overloaded Multiply Function
        
        int multiply(int a, int b) => a * b;
        double Multiply(double a, double b) => a * b;
        int MULtiply(int a, int b, int c) => a * b * c;

        Console.WriteLine($"Two Ints: {multiply(5, 10)}");
        Console.WriteLine($"Two Doubles: {Multiply(2.5, 4.0)}");
        Console.WriteLine($"Three Ints: {MULtiply(2, 3, 4)}");
        
        //Task 10: Overloaded Area Calculator
        
        double CALculateArea(double side) => side * side;
        double CAlculateArea(double length, double width) => length * width;

        Console.WriteLine("Calculate Area: 1) Square 2) Rectangle");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter side: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {CALculateArea(s)}");
        }
        else
        {
            Console.Write("Enter length and width: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {CalculateArea(a, b)}");
        }
    }
}    
