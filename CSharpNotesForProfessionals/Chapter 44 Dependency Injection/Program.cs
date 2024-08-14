// See https://aka.ms/new-console-template for more information
using Chapter_44_Dependency_Injection_Section_44_1;
using System.Runtime.CompilerServices;
using Unity;

Console.WriteLine("Chapter 44: Dependency Injection");
Console.WriteLine();
Console.WriteLine("Section 44.1: Dependency Injection C# and ASP.NET with Unity");

var containner = new UnityContainer();

containner.RegisterType<ISantaAndHisReindeer, SantaAndHisReindeer>();

var animalController = containner.Resolve<AnimalV2Controller>();

animalController.DoWork();

Console.WriteLine();
Console.WriteLine("Section 44.2: Dependency injection using MEF");