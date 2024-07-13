// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("Chapter 35: Dynamic type");
Console.WriteLine("Section 35.1: Creating a dynamic object with properties");

dynamic info = new ExpandoObject();

info.Id = 123;
info.Another = 456;

Console.WriteLine(info.Another);

//Console.WriteLine(info.DoesntExist);

Console.WriteLine();
Console.WriteLine("Section 35.2: Creating a dynamic variable");

dynamic foo = 123;
Console.WriteLine(foo + 234);
//Console.WriteLine(foo.ToUpper());
foo = "123";
Console.WriteLine(foo + 234);
Console.WriteLine(foo.ToUpper());

Console.WriteLine();
Console.WriteLine("Section 35.3: Returning dynamic");

var value = GetValue();
Console.WriteLine(value);
static dynamic GetValue()
{
    return "dynamics are useful!";

};

Console.WriteLine();
Console.WriteLine("Section 35.4: Handling Specific Types Unknown at Compile Time");


public class IfElseExample
{
    public string DebugToString(object a)
    {
        if (a is StringBuilder)
        {
            return DebugToStringInternal(a as StringBuilder);
        }
        else if (a is List<string>)
        {
            return DbugToStringInternal(a as List<string>);
        }
        else
        {
            return a.ToString();
        }

    }

    private string DebugToStringInternal(object a)
    {
        return a.ToString();
    }

    private string DebugToStringInternl(StringBuilder sb)
    {
        return $"StringBuilder - Capacity : {sb.Capacity}, MaxCapacity: {sb.MaxCapacity}, Value: {sb.ToString()}";
    }

    private string DbugToStringInternal(List<string> list)
    {
        return $"List<string> - Count: {list.Count}, Value: {Environment.NewLine + "\t" + string.Join(Environment.NewLine + "\t", list.ToArray())}";
    }
}

class DynamicExample
{
    public string DebugToString(object a)
    {
        return DebugToStringInternal((dynamic)a);
    }

    private string DebugToStringInternal(object a)
    {
        return a.ToString();
    }

    private string DebugToStringInternal(StringBuilder sb)
    {
        return $"StringBuilder - Capacity: {sb.Capacity}, MaxCapacity: {sb.MaxCapacity}, Value: {sb.ToString()}";
    }

    private string DebugToStringInternal(List<string> list)
    {
        return $"List<string> - Count : {list.Count}, Value: {Environment.NewLine + "\t" + string.Join(Environment.NewLine + "\t", list.ToArray())}";
    }
}