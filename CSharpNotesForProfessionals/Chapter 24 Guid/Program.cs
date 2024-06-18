namespace Chapter_24_Guid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter 24: Guid");
            Console.WriteLine("Section 24.1: Getting the string representation of a Guid");
            string MyGuidString = Guid.NewGuid().ToString();

            var myGuid = new Guid(MyGuidString);

            Console.WriteLine($"Format Guid with N(None) : {myGuid.ToString("N")}");
            Console.WriteLine($"Format Guid with D(Hyphens) : {myGuid.ToString("D")}");
            Console.WriteLine($"Format Guid with B(Braces) : {myGuid.ToString("B")}");
            Console.WriteLine($"Format Guid with P(Parentheses) : {myGuid.ToString("P")}");
            Console.WriteLine($"Format Guid with X(Hex) : {myGuid.ToString("X")}");

            Console.WriteLine();
            Console.WriteLine("Section 24.2: Creating a Guid");
            Guid g = Guid.Empty;
            Guid g2 = new Guid();
            Guid g3 = Guid.NewGuid();

            Guid g4 = new Guid("0b214de7-8958-4956-8eed-28f9ba2c47c6");
            Guid g5 = new Guid("0b214de7895849568eed28f9ba2c47c6");
            Guid g6 = new Guid("0b214de7-8958-4956-8eed-28f9ba2c47c6");

            Console.WriteLine();
            Console.WriteLine("Section 24.3: Declaring a nullable GUID");
            Guid? myGuidVar = null;
        }
    }
}