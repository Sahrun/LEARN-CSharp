// See https://aka.ms/new-console-template for more information
using Chapter_63_Reflection;
using Chapter_63_Reflection_Section_63_1;
using Chapter_63_Reflection_Section_63_2;
using Chapter_63_Reflection_Section_63_3;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;

Console.WriteLine("Hello, World!");
Console.WriteLine("Section 63.1: Get the members of a type");
new GetmemberList();
Console.WriteLine("Section 63.2: Get a method and invoke it");
new Program1();
Console.WriteLine("Section 63.3: Creating an instance of a Type");

var testcls = new TestClass("param1");
testcls.TestMethod();


// Section 63.4: Get a Strongly-Typed Delegate to a Method or Property via Reflection

new Section_63_4();

// Section 63.5: Get a generic method and invoke it

new Section_63_5();

// Section 63.6: Get a System.Type

var theString = "hello";
var theType = theString.GetType();
theType = typeof(string);

// Section 63.7: Getting and setting properties

MyClass myCls = new MyClass();

PropertyInfo prop = myCls.GetType().GetProperty("MyIntProperty");

// get value
object value = prop.GetValue(myCls);

// set value
int newValue = 3;
prop.SetValue(myCls, newValue);

// get backing field info
FieldInfo fieldInfo = myCls.GetType().GetField("<MyPrivateProperty>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic);

fieldInfo.SetValue(myCls, newValue);

Console.WriteLine(newValue);

// Section 63.8: Create an instance of a Generic Type and invoke it's method
new Section_63_8();

// Section 63.9: Custom Attributess
new Section_63_9();
//Section 63.10: Instantiating classes that implement an
//interface (e.g.plugin activation)
new Section_63_10();
// Section 63.11: Get a Type by name with namespace
new Section_63_11();

// Section 63.12 Determining generic arguments of instances of generic types

new Section_63_12();

// Section 63.13: Looping through all the properties of a class
new Section_63_13();