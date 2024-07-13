// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.JavaScript;
using static MyClass;

Console.WriteLine("Chapter 37: Casting");
Console.WriteLine("Section 37.1: Checking compatibility without casting");

string i = String.Empty;

if (i is int)
{
    Console.WriteLine(i + " is an " + i.GetType().Name);
}
else
{
    Console.WriteLine(i + " is not int, but is " + i.GetType().Name);
}

Console.WriteLine();
Console.WriteLine("Section 37.2: Cast an object to a base type");



MyClass obj = new MyClass();

IMyInterface1 myClass1 = (IMyInterface1)obj;
IMyInterface2 myClass2 = (IMyInterface2)obj;

Console.WriteLine("I am : {0}", myClass1.GetName());
Console.WriteLine("I am : {0}", myClass2.GetName());


Console.WriteLine("Section 37.3: Conversion Operators");

Console.WriteLine("Implisit");
JsExpression intExpression = new JsExpression("-1");
JsExpression doubleExpression = new JsExpression("-1.0");

Console.WriteLine(intExpression.isEqualsTo(doubleExpression));

Console.WriteLine("Explisit");
JsExpression intExpression1 = (JsExpression)(-1);
JsExpression doubleExpression1 = (JsExpression)(-1.0);
Console.WriteLine(intExpression1.isEqualsTo(doubleExpression1));

JsExpression intExpression2 = -1;
Console.WriteLine(intExpression2.isEqualsTo(-1.0));

Console.WriteLine();
Console.WriteLine("Section 37.4: LINQ Casting operations");

IEnumerable<IThing> things = new IThing[] { new Thing() };
IEnumerable<Thing> things2 = things.Cast<Thing>();
IEnumerable<Thing> things3 = things.OfType<Thing>();

//double[] doubles = new[] { 1, 2, 3 }.Cast<double>().ToArray();

double[] doubles1 = new[] { 1, 2, 3 }.Select(i => (double)i).ToArray();

Console.WriteLine();
Console.WriteLine("Section 37.5: Explicit Casting");
object value = -1;
int number = (int)value;
Console.WriteLine(Math.Abs(number));

Console.WriteLine();
Console.WriteLine("Section 37.6: Safe Explicit Casting (`as` operator)");
object value1 = "-1";
int? number1 = value1 as int?;
if (number1 != null)
{
    Console.WriteLine(Math.Abs(number1.Value));
}

Console.WriteLine();
Console.WriteLine("Section 37.7: Implicit Casting");
int number2 = -1;
object value2 = number2;
Console.WriteLine(value2);
Console.WriteLine(-1);
Console.WriteLine();
Console.WriteLine("Section 37.8: Explicit Numeric Conversions");
double value3 = -1.1;
int number3 = (int)value3;

Console.WriteLine(number3);
object value4 = -1.1;
int number4 = (int)value4;



public interface IMyInterface1
{
    string GetName();
}

public interface IMyInterface2
{
    string GetName();
}

public class MyClass : IMyInterface1, IMyInterface2
{
    string IMyInterface1.GetName()
    {
        return "IMyInterfae1";
    }
    string IMyInterface2.GetName()
    {

        return "IMyInterface2";
    }


    public class JsExpression
    {
        private readonly string expression;
        public JsExpression(string rawExpression)
        {
            this.expression = rawExpression;
        }

        public override string ToString()
        {
            return this.expression;
        }

        public JsExpression isEqualsTo(JsExpression othes)
        {
            return new JsExpression("(" + this + " == " + othes + ")");
        }

        //public static explicit operator JsExpression(int value)
        //{
        //    return new JsExpression(value.ToString());
        //}

        //public static explicit operator JsExpression(double value)
        //{
        //    return new JsExpression(value.ToString());
        //}


        public static implicit operator JsExpression(int value)
        {
            return new JsExpression(value.ToString());
        }

        public static implicit operator JsExpression(double value)
        {
            return new JsExpression(value.ToString());
        }



    }


}

#region LINQ Casting operations
interface IThing
{
}
class Thing : IThing
{

}
#endregion
