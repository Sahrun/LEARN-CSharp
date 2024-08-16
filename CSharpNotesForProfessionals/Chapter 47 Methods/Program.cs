// See https://aka.ms/new-console-template for more information
Console.WriteLine("Chapter 47: Methods");
Console.WriteLine("Section 47.1: Calling a Method");

// Single argument 
Console.WriteLine("Hello Word");

// Multiple arguments 
string name = "User";
Console.WriteLine("Hello, {0}!", name);

string input = Console.ReadLine();

int x = 42;
// The intance method called here is Int32.ToString();
string xAstring = x.ToString();

// Assuming a method 'T[] CreateArray<T>(int size)'
//DateTime[] dates = CreateArray<DateTime>(8);


Console.WriteLine("Section 47.2: Anonymous method");
int Add(int lhs, int rhs) => lhs + rhs;
Console.WriteLine("2 + 3 = " + Add(2, 3));
//Console.WriteLine("2 + 3 = " + IntOp(2, 3));
//delegate int IntOp(int lhs, int rhs);
//IntOp add = delegate(int lhs.int rhs)
//{
//    return lhs + rhs;
//}

//IntOp mul = (lhs,rhs) => { 
// return lhs + rhs;

//}

//IntOp sub = (lhs, rhs) => lhs - rhs;

Console.WriteLine("Section 47.3: Declaring a Method");

MethodExample example = new MethodExample();
Console.WriteLine(example.Sum());

Console.WriteLine("Section 47.4: Parameters and Arguments");

void Dosomething(int i, string s, object o)
{
    Console.WriteLine(String.Format("i = {0}, s={1}, o={2}", i, s, o));
}

Dosomething(x, "hello", new object());

Console.WriteLine("Section 47.5: Return Types");

Console.WriteLine("Section 47.6: Default Parameters");

Console.WriteLine("Section 47.7: Method overloading");
string squareArea = example.Area(2);
double rectangleArea = example.Area(32.0, 17.5);
double circleArea = example.Area(5.0);

Console.WriteLine("Section 47.8: Access rights");

// static: is callable on a class even when no instance of the class has been created
//public static void MyMethod()
// virtual: can be called or overridden in an inherited class
//public virtual void MyMethod()
// internal: access is limited within the current assembly
//internal void MyMethod()
//private: access is limited only within the same class
//private void MyMethod()
//public: access right from every class / assembly
//public void MyMethod()
//protected: access is limited to the containing class or types derived from it
//protected void MyMethod()
//protected internal: access is limited to the current assembly or types derived from the containing
//class.
//protected internal void MyMethod()

public class MethodExample
{
    private int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum()
    {
        return Sum(1, 2);
    }

    //Section 47.7: Method overloading

    public string Area(int value1)
    {
        return String.Format("Area of Square is {0}", value1 * value1);
    }

    public double Area(double value1, double value2)
    {
        return value1 * value2;
    }

    public double Area(double value1)
    {
        return 3.14 * Math.Pow(value1, 2);
    }

}

public interface IAreaCalculatorString
{
    public string Area(double with, double height);
}

public class AreaCalculator : IAreaCalculatorString
{
    string IAreaCalculatorString.Area(double with, double height)
    {
        return String.Format("Total Area : {0}", with * height);
    }

    public string Area(double with, double height)
    {
        return String.Format("Total Area : {0}", with * height);
    }
}