namespace Chapter_15_String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter 15: String Interpolation");
            Console.WriteLine();
            Console.WriteLine("Section 15.1: Format dates in strings");
            var date = new DateTime(2024, 03, 07);
            var str = $"It's {date:MMMM d, yyyy}, make a wish!";
            Console.WriteLine(str);

            Console.WriteLine();
            Console.WriteLine("Section 15.2: Padding the output");
            var number = 42;
            Console.WriteLine($"The answare to life, the universe and everiting is {number,5}.");
            Console.WriteLine($"The answare to life the universe and everiting is ${number,-5}.");

            Console.WriteLine();
            Console.WriteLine("Section 15.3: Expressions");
            var StrWithMathExpression = $"1 + 2 = {1 + 2}";
            Console.WriteLine(StrWithMathExpression);
            string word = "world";
            var StrWithFunctionCall = $"Hello, {word.ToUpper()}!";
            Console.WriteLine(StrWithFunctionCall);

            Console.WriteLine();
            Console.WriteLine("Section 15.4: Formatting numbers in strings");
            var decimalValue = 120.5;
            Console.WriteLine($"It costs {decimalValue:C}");

            Console.WriteLine($"Exactly {decimalValue:F3}");

            var integerValue = 57;
            Console.WriteLine($"{integerValue:D5}");

            Console.WriteLine();
            Console.WriteLine("Section 15.5: Simple Usage");
            var name = "Sahrun";
            str = $"Hello, {name}!";
            Console.WriteLine(str);
        }
    }
}