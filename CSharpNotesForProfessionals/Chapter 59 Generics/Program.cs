
using Chapter_59_Generics_Section_59_20;
using Chapter_59_Generics_Section_59_3;
using Chapter_59_Generics_Section_59_4;



Console.WriteLine("Chapter 59: Generics");
Console.WriteLine("Section 59.1: Implicit type inference (methods)");

Console.WriteLine("Section 59.2: Type inference (classes)");

Console.WriteLine("Section 59.3: Using generic method with an interface as a constraint type");

var gress = new Grass();
var sheep = new Herbivore();
var lion = new Carnivore();


sheep.Eat(gress);
sheep.Eat<Grass>(gress);

lion.Eat(sheep);

//sheep.Eat(lion); cannot used , because is not implement interface IFood

Console.WriteLine("Section 59.4: Type constraints (new-keyword)");
Foo f = new Factory<Foo>().Create();
//Bar b = new Factory<Bar>().Create(); cannot use , because class has have constructor default 
// without param

Console.WriteLine("Section 59.5: Type constraints (classes and interfaces)");

Console.WriteLine("Section 59.6: Checking equality of generic values");

Console.WriteLine("Section 59.7: Reflecting on type parameters");

Console.WriteLine("Section 59.8: Covariance");

Console.WriteLine("Section 59.9: Contravariance");


Console.WriteLine("Section 59.10: Invariance");

Console.WriteLine("Section 59.11: Variant interfaces");

Console.WriteLine("Section 59.12: Variant delegates");

Console.WriteLine("Section 59.13: Variant types as parameters and return values");

Console.WriteLine("Section 59.14: Type Parameters (Interfaces)");

Console.WriteLine("Section 59.15: Type constraints (class and struct)");

Console.WriteLine("Section 59.16: Explicit type parameters");

Console.WriteLine("Section 59.17: Type Parameters (Classes)");

Console.WriteLine("Section 59.18: Type Parameters (Methods)");

Console.WriteLine("Section 59.19: Generic type casting");

Console.WriteLine("Section 59.20: Configuration reader with generic type casting");
var timeOut = ConfigurationReader.GetConfigKeyValue("RequestTimeout", 2000);
var url = ConfigurationReader.GetConfigKeyValue("URL", "www.someurl.com");
var enabled = ConfigurationReader.GetConfigKeyValue("IsEnabled", false);