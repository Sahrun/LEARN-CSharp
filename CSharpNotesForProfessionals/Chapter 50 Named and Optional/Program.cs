
using System.Runtime.InteropServices;

Console.WriteLine("Chapter 50: Named and Optional\r\nArguments");
Console.WriteLine();
Console.WriteLine("Section 50.1: Optional Arguments");

Console.WriteLine("Area with Optional Argument :");
var area = FindAreWithOptional(120);
Console.WriteLine(area);

area = FindAreWithOptional1(120);

Console.WriteLine(area);

Console.WriteLine();
Console.WriteLine("Section 50.2: Named Arguments");
double area1;
Console.WriteLine("Area with positioned argument is: ");
area1 = FindArea(120, 56);
Console.WriteLine(area1);

Console.WriteLine("Area with Named argument is: ");
area1 = FindArea(length: 120, width: 56);
Console.WriteLine(area1);

Console.WriteLine("Area with Named argument vice versa is: ");
area1 = FindArea(width: 120, length: 56);
Console.WriteLine(area1);


Console.WriteLine("Area width named argument Positional Argument : ");
area1 = FindArea(120, width: 56);
Console.WriteLine(area);





static double FindAreWithOptional(int length, int with = 56)
{
    try
    {
        return (length * with);
    }
    catch (Exception)
    {
        throw new NotImplementedException();
    }

}

static double FindAreWithOptional1(int lenth, [Optional] int with)
{
    try
    {
        return (lenth * with);
    }
    catch (Exception)
    {
        throw new NotImplementedException();
    }
}

static double FindArea(int length, int width)
{
    try
    {
        return (length * width);
    }
    catch (Exception)
    {
        throw new NotImplementedException();
    }
}