namespace ProblemsCSharp;

class Program
{
    static void Main(string[] args)
    {
        // Kattis fizzbuzz
        FizzBuzzKattis fizzBuzzKattis = new FizzBuzzKattis();
        fizzBuzzKattis.FizzBuzz();

        Console.Write("\n");

        // Leet codes fizzbuzz
        FizzBuzzLeetcode fizzBuzzLeetcode = new FizzBuzzLeetcode();
        IList<string> result = new List<string>();
        int number = 5;
        result = fizzBuzzLeetcode.FizzBuzz(number);

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(result[i]);
        }

    }
    public static void Test()
    {
        decimal y = 12.3m;
        Console.WriteLine(34.40M);
        Console.WriteLine("Windows " + 1 + 1);
        Console.WriteLine("Windows " + 11);
        Console.WriteLine("Windows " + 7 + 4);
        Console.WriteLine(5 / 10);
        Console.WriteLine("Student\t\tGrade");
        decimal x = 7 / 5; ;
        Console.WriteLine(x);


        Cake cake = new()
        {
            Name = "strawberry short cake",
            Flavour = "vanilla",
            Price = 10,
            Topping = "strawberries, cream"
        };
        Console.WriteLine("{0}, {1}, {2}, {3}", cake.Name, cake.Flavour, cake.Price, cake.Topping);
    }
}

class Cake
{
    public string? Name { get; set; }
    public string? Flavour { get; set; }
    public int Price { get; set; }
    public string? Topping { get; set; }
}

