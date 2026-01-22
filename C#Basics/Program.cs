class Program
{

    static void Main()
    {
        PrintEvenNumbers(20);
        Multiply(5, 10);
        bool isAdult = IsAdult(22);
        Console.WriteLine(isAdult);
    }
    static void Day1()
    {
        int age = 27;
        double salary = 41000.50;
        string name = "Meirn";
        bool isEmployed = false;
        char grade = 'A';

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Employment Status: " + isEmployed);
        Console.WriteLine("Grade: " + grade);
    }

    static void Day2()
    {
        Console.Write("Enter your age ");
        int age = int.Parse(Console.ReadLine());
        if(age >= 18)
        {
            Console.WriteLine("Eligible");
        }
        else
        {
            Console.WriteLine("Not Eligible");
        }
    }

    static void Day3()
    {
        for(int i= 1; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        int x = 1;
        while (x < 5)
        {
            Console.WriteLine(x);
            x++;
        }

        string password = "";
        while (password != "merin@123")
        {
            Console.Write("Enter password");
            password = Console.ReadLine();

        }
        Console.WriteLine("Access granted");

        string[] employees = { "merin, eldhose, anna" };
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }

        //multiplication

        Console.Write("Enter a number");
        string input = Console.ReadLine();
        if(int.TryParse(input, out int num))
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {num} = {i*num}");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }   
    }

    //Day 4
    //print even numbers
    static void PrintEvenNumbers(int limit)
    {
        for (int i = 2; i <= limit; i = i+2)
        {
            Console.WriteLine(i);
        }
        int x = 2;
        while(limit>=x)
        {
            Console.WriteLine(x);
            x=x+2;
        }
    }
    //Multiply
    static void Multiply(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a*b}");
    }
    //IsAdult
    static bool IsAdult(int age)
    {
        return age >= 18;
    }
}