// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Chapter 34: Anonymous types");
Console.WriteLine();
Console.WriteLine("Section 34.1: Anonymous vs dynamic");

var anon = new { Value = 1 };
Console.WriteLine(anon);

dynamic val = "foo";
//Console.WriteLine(val.Id);

Console.WriteLine();
Console.WriteLine("Section 34.2: Creating an anonymous type");

var anon2 = new { Foo = 1, Bar = 2 };

int foo = 1;
int bar = 2;

var anon3 = new { foo, bar };

string foos = "some string";

var anom4 = new { foos.Length };

Console.WriteLine(anom4.Length);

//var anom5 = new { foos.Length <= 10 ? "short string" : "long string" };

var anom6 = new { Description = foos.Length <= 10 ? "short string" : "long string" };

Console.WriteLine();
Console.WriteLine("Section 34.3: Anonymous type equality");
var anom7 = new { Foo = 1, Bar = 2 };
var anom8 = new { Foo = 1, Bar = 2 };
var anom9 = new { Foo = 51, Bar = 10 };
//var anom9 = new { Foo = 1, Bar = 2 };
var anom10 = new { Bar = 2, Foo = 1 };

var eq = anom7.Equals(anom8);
var eq1 = anom7.Equals(anom9);

var eq2 = anom7.Equals(anom10);


var ann = new { Foo = 1, Bar = 2 };
var ann2 = new { Foo = 7, Bar = 10 };
var ann3 = new { Bar = 1, Foo = 3 };
var ann4 = new { Fa = 1, Bar = 2 };

var _eq1 = ann.Equals(ann2);
var _eq2 = ann.Equals(ann3);
var _eq3 = ann.Equals(ann4);

Test.Log(new { Value = 10 });

Console.WriteLine();

var products = new[] {
new {Amount =10,Id=0 },
new {Amount = 20, Id =1 },
new {Amount = 30, Id =2 },
};

var idsByAmount = products.OrderBy(x => x.Amount).Select(x => x.Id);

Console.WriteLine(idsByAmount);

Console.WriteLine();
Console.WriteLine("Section 34.5: Instantiating generic types with anonymous types");

var anon11 = new { Foo = 1, Bar = 2 };
var anon12 = new { Foo = 5, Bar = 10 };

var list1 = Test.CreateList(anon11, anon12);
var list2 = new[] { anon11, anon12 }.ToList();

Console.WriteLine();
Console.WriteLine("Section 34.6: Implicitly typed arrays");

var arr = new[] { new { Id = 0 }, new { Id = 1 } };

Console.WriteLine();
public static class Test
{

    public static void Log<T>(T obj)
    {
        Console.WriteLine(obj);
    }

    public static List<T> CreateList<T>(params T[] items)
    {
        return new List<T>(items);
    }
}


