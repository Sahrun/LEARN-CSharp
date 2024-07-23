using Chapter_43_Singleton_Implementation_Section_43_2;

Console.WriteLine();
Console.WriteLine("Chapter 43: Singleton Implementation");
Console.WriteLine();
Console.WriteLine("Section 43.1: Statically Initialized Singleton");

Console.WriteLine();
Console.WriteLine("Section 43.2: Lazy, thread-safe Singleton (using Lazy<T>)");
var instance = LazySingleton.instance;

Console.WriteLine();
Console.WriteLine("Section 43.3: Lazy, thread-safe Singleton (using Double\r\nChecked Locking)");

Console.WriteLine();
Console.WriteLine("Section 43.4: Lazy, thread safe singleton (for .NET 3.5 or\r\nolder, alternate implementation)\r\n");
