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
        
        //Task 11: Function-Based Calculator
        double Add(double a, double b) => a + b;
        double Subtract(double a, double b) => a - b;
        double MultiplyNumbers(double a, double b) => a * b;
        double DivideNumbers(double a, double b) 
        {
            try { return a / b; }
            catch (DivideByZeroException) { return 0; }
        }

        void DisplayResult(string op, double result) => Console.WriteLine($"Operation: {op} | Result: {result}");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1) Add 2) Subtract 3) Multiply 4) Divide 5) Exit");
            string Choice = Console.ReadLine();
            if (Choice == "5") { running = false; continue; }

            Console.Write("Enter two numbers: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            switch (Choice)
            {
                case "1": DisplayResult("Addition", Add(n1, n2)); break;
                case "2": DisplayResult("Subtraction", Subtract(n1, n2)); break;
                case "3": DisplayResult("Multiplication", MultiplyNumbers(n1, n2)); break;
                case "4": DisplayResult("Division", DivideNumbers(n1, n2)); break;
            }
        }
        
        //Task 12: Student Report Card Generator
        double CalculateAverage(double s1, double s2, double s3) => (s1 + s2 + s3) / 3;

        string getGradeLetter(double avg)
        {
            if (avg >= 90) return "A";
            if (avg >= 80) return "B";
            if (avg >= 70) return "C";
            if (avg >= 60) return "D";
            return "F";
        }

        void PrintReportCard(string name, double avg, string grade)
        {
            Console.WriteLine("\n--- Student Report Card ---");
            Console.WriteLine($"Name:    {name}");
            Console.WriteLine($"Average: {avg:F2}");
            Console.WriteLine($"Grade:   {grade}");
            Console.WriteLine("---------------------------");
        }

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter three scores: ");
        double score1 = double.Parse(Console.ReadLine());
        double score2 = double.Parse(Console.ReadLine());
        double score3 = double.Parse(Console.ReadLine());

        double average = CalculateAverage(score1, score2, score3);
        string letter = getGradeLetter(average);
        PrintReportCard(name, average, letter);
    }
}    
