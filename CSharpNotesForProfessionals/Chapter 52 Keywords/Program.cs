using Chapter_52_Keywords_9;
using Chapter_52_Keywords_Section_52_10;
using Chapter_52_Keywords_Section_52_11;
using Chapter_52_Keywords_Section_52_13;
using Chapter_52_Keywords_Section_52_2;
using Chapter_52_Keywords_Section_52_20;
using Chapter_52_Keywords_Section_52_21;
using Chapter_52_Keywords_Section_52_27;
using Chapter_52_Keywords_Section_52_29;
using Chapter_52_Keywords_Section_52_3;
using Chapter_52_Keywords_Section_52_38;
using Chapter_52_Keywords_Section_52_39;
using Chapter_52_Keywords_Section_52_4;
using Chapter_52_Keywords_Section_52_5;
using Chapter_52_Keywords_Section_52_6;
using Chapter_52_Keywords_Section_52_7;
using Chapter_52_Keywords_Section_52_8;
using Chapter_52_Keywords_Section_52_42;
using System.Security.Cryptography;
using System.Text;
using Chapter_52_Keywords_Section_52_53;
using Chapter_52_Keywords_Section_52_59;

Console.WriteLine("Chapter 52: Keywords");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Section 52.1: as");

object something = "Hello";
Console.WriteLine(something as string);
Console.WriteLine(something as Nullable<int>);
Console.WriteLine(something as int?);

//Console.WriteLine(something as int);

// Equivalent
Console.WriteLine(something is string ? (string)something : null);


Console.WriteLine();
Console.WriteLine("Section 52.2: goto");

Section_52_2 section_52_2 = new Section_52_2();
//section_52_2.InfiniteHello();

Console.WriteLine("goto : Case statement:");
bool isPermission = section_52_2.GetPermission(Permissions.Write);
Console.WriteLine("Is Allow Read: {0}", isPermission);

isPermission = section_52_2.GetPermission(Permissions.Read);
Console.WriteLine("Is Allow Read : {0}", isPermission);

Console.WriteLine("goto : Exception Retry");
section_52_2.RetryGoto();

Console.WriteLine();
Console.WriteLine("Section 52.3: volatile");

ExampleVolatile example = new ExampleVolatile();

Thread thread1 = new Thread(example.DoStuff);
Thread thread2 = new Thread(example.DoStuff);
Thread thread3 = new Thread(example.DoStuff);

thread1.Start();
thread2.Start();
thread3.Start();

thread1.Join();
thread2.Join();
thread3.Join();

Console.WriteLine("All threads completed.");

Console.WriteLine();
Console.WriteLine("Section 52.4:  checked, unchecked");
string myString = "The checked and unchecked keywords define how operations handle mathematical overflow. \"Overflow\" in the\r\ncontext of the checked and unchecked keywords is when an integer arithmetic operation results in a value which is\r\ngreater in magnitude than the target data type can represent";
var has = Encoding.ASCII.GetBytes(myString);

CheckedUnchecked checkedUnchecked = new CheckedUnchecked();

var res = checkedUnchecked.Checksum(has);
Console.WriteLine();

int unchekInt = checkedUnchecked.intUnchecked();

Console.WriteLine("result unchecked : {0}", unchekInt);

Console.WriteLine();
Console.WriteLine("Section 52.5: virtual, override, new");

BaseClass baseCls = new BaseClass();
DerivedClass derivedClass = new DerivedClass();
SecondDerivedClass secondDerivedClass = new SecondDerivedClass();

baseCls.Foo();
derivedClass.Foo();
secondDerivedClass.Foo();

Console.WriteLine("Implementation Keyword New");

BaseClass1 obj1 = new BaseClass1();
obj1.Foo();
obj1 = new DerivedClass1();
obj1.Foo();


Console.WriteLine("Derived classes can introduce polymorphism");

A a = new A();
a.Foo();
a = new B();
a.Foo();

B b = new B();
b.Foo();

Console.WriteLine();
Console.WriteLine("Section 52.6: stackalloc");
Section_52_6 section_52_6 = new Section_52_6();


Console.WriteLine();
Console.WriteLine("Section 52.7: break");
Section_52_7 section_52_7 = new Section_52_7();

foreach (var item in section_52_7.GetNumbers())
{
    Console.WriteLine(item);
};

Console.WriteLine("Section 52.8: const");
Section_52_8 section_52_8 = new Section_52_8();
section_52_8.CalculateEnergy(100000);

Console.WriteLine("Section 52.9: async, await");

Section_52_9 section_52_9 = new Section_52_9();
await section_52_9.DoSomethingAsync();
await section_52_9.PrintAndDelayAsync("Message", 1000);

Console.WriteLine("Section 52.10: for");
Section_52_10 section_52_10 = new Section_52_10();
section_52_10.Method_1();
//section_52_10.Method_2();
section_52_10.Method_3();


Console.WriteLine("Section 52.11: abstract");
Animal cat = new Cat();
cat.MakeSound();

Animal dog = new Dog();
dog.MakeSound();

//Animal animal = new Animal();

Console.WriteLine("Section 52.12: fixed");

Console.WriteLine();
Console.WriteLine("Section 52.13: default");
Section_52_13 section_52_13 = new Section_52_13();

Console.WriteLine("Section 52.14: sealed");

Console.WriteLine("Section 52.15: is");

Console.WriteLine("Section 52.16: this");

Console.WriteLine("Section 52.17: readonly");

Console.WriteLine("Section 52.18: typeof");

Type type = typeof(string);
Console.WriteLine(type.FullName); //System.String
Console.WriteLine("Hello".GetType() == type); //True
Console.WriteLine("Hello".GetType() == typeof(string)); //True
Console.WriteLine(typeof(Animal));

Console.WriteLine("Section 52.20: dynamic");
new Section_52_20();

Console.WriteLine("Section 52.21: try, catch, finally, throw");
new Section_52_21();

Console.WriteLine("Section 52.22: void");
Console.WriteLine("Section 52.23: namespace");

Console.WriteLine("Section 52.24: ref, out");

Console.WriteLine("Section 52.25: base");


Console.WriteLine("Section 52.26: float, double, decimal");

Console.WriteLine("Section 52.27: operator");
var vector1 = new Vector32(15, 39);
var vector2 = new Vector32(87, 64);

Console.WriteLine(vector1 == vector2); // false
Console.WriteLine(vector1 != vector2); // true
Console.WriteLine(vector1 + vector2); // {102, 103}
Console.WriteLine(vector1 - vector2); // {-72, -25}

Console.WriteLine("Section 52.28: char");
//char c = 'c';
//char c = '\u0063'; //Unicode
//char c = '\x0063'; //Hex
//char c = (char)99;//Integral

Console.WriteLine("Section 52.29: params");
Section_52_29 section_52_29 = new Section_52_29();
Section_52_29.AddAll(5, 10, 15, 20);
Section_52_29.AddAll(new int[] { 5, 10, 15, 20 });
Section_52_29.Add(2, 3); //prints "Add with 2 ints"
Section_52_29.Add(2, 3.0); //prints "Add with array of doubles" (doubles are not ints)
Section_52_29.Add(2, 3, 4); //prints "Add with array of doubles" (no 3 argument overload)

Console.WriteLine("Section 52.30: while");
int i = 0;
while (i++ < 5)
{
    Console.WriteLine("While is on loop number {0}.", i);
}

bool a1 = false;
while (a1 == true)
{
    Console.WriteLine("This will never be printed.");
}

Console.WriteLine("Section 52.31: null");

object objA = null;
string strB = null;
int? c = null;
List<int> d = null;
//int a = null;
//float b = null;
//decimal c = null;
Console.WriteLine("Section 52.32: continue");

Console.WriteLine("Section 52.33: string");

Console.WriteLine("Section 52.34: return");

Console.WriteLine("Section 52.35: unsafe");

Console.WriteLine("Section 52.36: switch");

Console.WriteLine("Section 52.37: var");

Console.WriteLine("Section 52.38: when");

new Section_52_38();

Console.WriteLine("Section 52.39: lock");

new Section_52_39();

uint ui = 425697;
var ui1 = 789247U;
int ui3 = -4;

Console.WriteLine("Section 52.41: if, if...else, if... else if");


Console.WriteLine("Section 52.42: static");

ClassStatic _a = new ClassStatic();
ClassStatic _b = new ClassStatic();
ClassStatic _c = new ClassStatic();

Console.WriteLine(ClassStatic.count);

ConsoleAppsStatic.Main();


Console.WriteLine("Section 52.43: internal");

Console.WriteLine("Section 52.44: using");

Console.WriteLine("Section 52.45: where");

Console.WriteLine("Section 52.46: int");

Console.WriteLine("Section 52.47: ulong");

Console.WriteLine("Section 52.48: true, false");

Console.WriteLine("Section 52.49: struct");

Console.WriteLine("Section 52.50: extern"); // Keren

Console.WriteLine("Section 52.51: bool");

Console.WriteLine("Section 52.52: interface");

Console.WriteLine("Section 52.53: delegate");

new DelegateExample().Run();

Console.WriteLine("Section 52.54: unchecked");

Console.WriteLine("Section 52.55: ushort");

Console.WriteLine("Section 52.56: sizeof");

Console.WriteLine("Section 52.57: in");

Console.WriteLine("Section 52.58: implicit");

Console.WriteLine("Section 52.59: do");

new Section_52_59();

Console.WriteLine("Section 52.60: long");

Console.WriteLine("Section 52.61: enum");

Console.WriteLine("Section 52.62: partial");

Console.WriteLine("Section 52.63: event");

Console.WriteLine("Section 52.64: sbyte");