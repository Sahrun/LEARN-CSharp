using Chapter_42_Static_Classes;
using System.Runtime.CompilerServices;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Chapter 42: Static Classes");
Console.WriteLine();
Console.WriteLine("Section 42.1: Static Classes");

Foo.Counter++;
Console.WriteLine(Foo.GetCount());

Console.WriteLine();
Console.WriteLine("Section 42.2: Static class lifetime");


Console.WriteLine("Static classes are lazily initialized");
Console.WriteLine("The static construktor inonly invoked when the class is first accessed");
Chapter_42_Static_Classes_Section_42.Foo.SayHi();
Console.WriteLine("Reflecting on type won't trigger its static .ctor");
var barTypw = typeof(Chapter_42_Static_Classes_Section_42.Bar);

Console.WriteLine("Howaver, you can manually trigger it with System.Runtime.CompilerServices.RuntimeHelpers");

RuntimeHelpers.RunClassConstructor(barTypw.TypeHandle);

Console.WriteLine();
Console.WriteLine("Section 42.3: Static keyword");
var foo1 = new Chapter_42_Static_Classes_Section_43.Foo();
Console.WriteLine(foo1.NonStaticCounter);
Console.WriteLine(Chapter_42_Static_Classes_Section_43.Foo.Counter);

var foo2 = new Chapter_42_Static_Classes_Section_43.Foo();

Console.WriteLine(foo2.NonStaticCounter);
Console.WriteLine(Chapter_42_Static_Classes_Section_43.Foo.Counter);

