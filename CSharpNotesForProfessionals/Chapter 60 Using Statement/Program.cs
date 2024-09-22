using Chapter_60_Using_Statement_Section_60_4;
using Chapter_60_Using_Statement_Section_60_5;
using Chapter_60_Using_Statement_Section_60_6;

Console.WriteLine("Chapter 60: Using Statement");

Console.WriteLine("Section 60.1: Using Statement Basics");

Console.WriteLine("Section 60.2: Gotcha: returning the resource which you are disposing");

Console.WriteLine("Section 60.3: Multiple using statements with one block");

Console.WriteLine("Section 60.4: Gotcha: Exception in Dispose method masking other errors in Using blocks");

new ImplementDispose();

Console.WriteLine("Section 60.5: Using statements are null-safe");

new NullSafe();

Console.WriteLine("Section 60.6: Using Dispose Syntax to define custom scope");


using (new CultureContext("id-ID"))
{
    Console.WriteLine(new DateTime(2016, 12, 25));
}
using (new CultureContext("es-ES"))
{
    Console.WriteLine(new DateTime(2016, 12, 25));
}

Console.WriteLine(new DateTime(2016, 12, 25));

Console.WriteLine("Section 60.7: Using Statements and Database Connections");

Console.WriteLine("Section 60.8: Executing code in constraint context");

