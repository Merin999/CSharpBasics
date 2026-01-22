class Program
{

    static void Main()
    {
        //Day1();
        //Day2();
        //Day3();

        //Day-4

        //-----print even numbers----s
        //PrintEvenNumbers(20);
        //Multiply(5, 10);
        //bool isAdult = IsAdult(22);
        //Console.WriteLine(isAdult);

        //Day5

        //----age print----
        //List<int> ages = new List<int>();
        //ages.Add(10);
        //ages.Add(20);
        //ages.Add(27);
        //ages.Add(89);
        //ages.Add(2);
        //Printadults(ages);
        //Console.WriteLine(ages.Count);      // number of items
        //ages.Remove(18);                    // removes first match
        //bool has22 = ages.Contains(22);     // true / false

        //----StringPrint();----
        //List<int> marks = new List<int>();
        //marks.Add(80);
        //marks.Add(100);
        //marks.Add(40);
        //marks.Add(60);
        //marks.Add(70);
        //Marks(marks);
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
        if (age >= 18)
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
        for (int i = 1; i < 5; i++)
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
        if (int.TryParse(input, out int num))
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
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
        for (int i = 2; i <= limit; i = i + 2)
        {
            Console.WriteLine(i);
        }
        int x = 2;
        while (limit >= x)
        {
            Console.WriteLine(x);
            x = x + 2;
        }
    }
    //Multiply
    static void Multiply(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
    //IsAdult
    static bool IsAdult(int age)
    {
        return age >= 18;
    }

    //Day 5
    //print adults
    static void Printadults(List<int> ages)
    {
        foreach (int age in ages)
        {
            if (age >= 18)
            {
                Console.WriteLine(age);
            }
        }
    }

    //strings
    static void StringPrint()
    {
        List<string> names = new List<string>()
        {
        "merin","eldhose","anna"
        };
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void Marks(List<int>marks)
    {
        int total = 0;
        foreach (int mark in marks)
        {
            if(mark >= 50)
            {
                Console.WriteLine(mark);
            }
            total += mark;  
        }
        double average = total / marks.Count;
        Console.WriteLine($"Total marks : {total}");
        Console.WriteLine($"Average mark : {average}");
    }
}