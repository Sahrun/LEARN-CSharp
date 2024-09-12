using Chapter_58_Inheritance;
using Chapter_58_Inheritance_Section_58_8;

Console.WriteLine("Chapter 58: Inheritance");
Console.WriteLine("Section 58.1: Inheritance. Constructors' calls sequence");
Console.WriteLine("Section 58.2: Inheriting from a base class");
Console.WriteLine("Section 58.3: Inheriting from a class and implementing an interface");
new Chapter_58_Inheritance_Section_58_3.Cat();

Console.WriteLine("Section 58.4: Inheriting from a class and implementing multiple interfaces");

Console.WriteLine("Section 58.5: Constructors In A Subclass");

Console.WriteLine("Section 58.6: Inheritance Anti-patterns");

Console.WriteLine("Section 58.7: Extending an abstract base class");

Console.WriteLine("Section 58.8: Testing and navigating inheritance");

new NavigationInheritance();

Console.WriteLine("Section 58.9: Inheriting methods");

Console.WriteLine("Section 58.10: Base class with recursive type specification");
var Q = Part.Empty.Add(2.5f);
var P = Q.Add(4.2f);
var R = P.Add(0.4f);
var Z = Q.Add(0.9f);


float weight = Q.TotalWeight;
Console.WriteLine(weight);

var A1 = RelativeCoordinate.Start;
var B1 = A1.Add(100, 20);
var B2 = A1.Add(160, 10);

var C1 = B1.Add(120, -40);
var C2 = B2.Add(10, -20);
var C3 = B2.Add(60, -30);

double dist1 = C1.TotalDistance;

Console.WriteLine(dist1);