// See https://aka.ms/new-console-template for more information
Console.WriteLine("Chapter 36: Type Conversion");
Console.WriteLine("Section 36.1: Explicit Type Conversion");

double d = 5673.74;
int i;
i = (int)d;
Console.WriteLine(i);

Console.WriteLine();
Console.WriteLine("Section 36.2: MSDN implicit operator example");
Digit dig = new Digit(7);
double num = dig;

Digit dig2 = 12;
Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);
Console.WriteLine();

class Digit
{

    public Digit(double d)
    {
        val = d;
    }
    public double val;

    public static implicit operator double(Digit d)
    {
        Console.WriteLine("Digit to double implicitt conversion called");
        return d.val;
    }

    public static implicit operator Digit(Double d)
    {
        Console.WriteLine("double to Digit implicit conversion called");
        return new Digit(d);
    }
}