
using Chapter_54_Recursion_Section_54_1;
using Chapter_54_Recursion_Section_54_6;

Console.WriteLine("Chapter 54: Recursion");

Console.WriteLine("Section 54.1: Recursion in plain English");
new Section_54_1();
new Section_54_1().fib(10);

Console.WriteLine("Section 54.3: PowerOf calculation");

Console.WriteLine("Section 54.4: Recursively describe an object structure");
Chapter_54_Recursion_Section_54_4.Program.Main(new string[] { "2", "3" });

Console.WriteLine("Section 54.5: Using Recursion to Get Directory Tree");

Chapter_54_Recursion_Section_54_5.Program.Main();

Console.WriteLine("Section 54.6: Factorial calculation");

new Factorial(5);