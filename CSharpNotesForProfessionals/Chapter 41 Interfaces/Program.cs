
using Chapter_41_Interfaces_Section_41_2_Explicit_interface_implementation;
using Chapter_41_Interfaces_Section_41_3_Interface_Basics;
using Chapter_41_Interfaces_Section_41_4_IComparable_T_as_an_Example_of_Implementing;
using Chapter_41_Interfaces_Section_41_6_Why_we_use_interfaces;
using Chapter_41_Interfaces_Section_41_7_Hiding_members_with_Explicit_Implementation;
using Chapter_41_Interfaces_Section41_1_Implementing_an_interface;

Console.WriteLine("Chapter 41: Interfaces");
Console.WriteLine("Section 41.1: Implementing an interface");

Console.WriteLine();
Console.WriteLine("Section 41.2: Explicit interface implementation");

GolfingChauffeur obj = new GolfingChauffeur();
IChauffeur chauffeur = obj;
IGolfPlayer golf = obj;

Console.WriteLine(obj.Drive());
Console.WriteLine(chauffeur.Drive());
Console.WriteLine(golf.Drive());

Console.WriteLine();
Console.WriteLine("Section 41.3: Interface Basics");

ICanDoThis obj1 = new MyClass();

obj1.TheThingCanDo();

obj1.SomeValueProperty = 5;

//obj1.SomeValueNotImplemtingAnything = 5;

((MyClass)obj1).SomeValueNotImplemtingAnything = 5;

Console.WriteLine();
Console.WriteLine("Section 41.4: IComparable<T> as an Example of Implementing\r\nan Interface");

Item apple = new Item();
apple.idNumber = 15;
Item banana = new Item();
banana.idNumber = 4;
Item cow = new Item();
cow.idNumber = 15;
Item diamond = new Item();
diamond.idNumber = 18;

Console.WriteLine(apple.CompareTo(banana)); // 11
Console.WriteLine(apple.CompareTo(cow)); // 0
Console.WriteLine(apple.CompareTo(diamond)); // -

List<Item> listitem = new List<Item> { apple, banana, cow };

listitem.Sort();

Console.WriteLine();
Console.WriteLine("Section 41.5: Implementing multiple interfaces");
new Cat();

Console.WriteLine();
Console.WriteLine("Section 41.6: Why we use interfaces");

var shapes = new List<IShape>() { new Rectangle(5, 10), new Circle(5) };


foreach (var shape in shapes)
{
    Console.WriteLine("Area: {0:N}", shape.ComputeArea());
}

Console.WriteLine();
Console.WriteLine("Section 41.7: \"Hiding\" members with Explicit Implementation");




