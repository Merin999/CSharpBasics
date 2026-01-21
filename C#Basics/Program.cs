class Program
{
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


    static void Main()
    {
        Day2();
    }
}