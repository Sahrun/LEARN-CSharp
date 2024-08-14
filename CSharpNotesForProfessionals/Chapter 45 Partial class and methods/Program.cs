using Chapter_45_Partial_class_and_methods;
using Chapter_45_Partial_class_and_methods_Section_45_1_Partial_classes;
using Chapter_45_Partial_class_and_methods;

Console.WriteLine("Chapter 45: Partial class and methods");

Console.WriteLine("Section 45.1: Partial classes");

PartialClass partial = new PartialClass();
partial.ExampleMethod();
partial.AnotherExampleMethod();

PartialClass_1 partial1 = new PartialClass_1();
partial1.Test();

Console.WriteLine("Section 45.3: Partial methods");
PartialClass_3 partialClass_3 = new PartialClass_3();
partialClass_3.ExportMethod();