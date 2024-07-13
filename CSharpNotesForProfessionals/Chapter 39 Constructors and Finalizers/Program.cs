
Console.WriteLine();
Console.WriteLine("Chapter 39: Constructors and Finalizers");

Console.WriteLine();
Console.WriteLine("Section 39.1: Static constructor");


var turtle = new Animal();
var giraffe = new Animal();

Animal.Yamn();

Console.WriteLine();
Console.WriteLine("Section 39.2: Singleton constructor pattern");

Console.WriteLine();
Console.WriteLine("Section 39.3: Default Constructor");

var nyAnimal = new Animal1("Fluffy");
var unnamedAnimal = new Animal1();

Console.WriteLine();
Console.WriteLine("Section 39.4: Forcing a static constructor to be called");

Console.WriteLine();
Console.WriteLine("Section 39.5: Calling a constructor from another constructor");
var dog = new Animal2();
var cat = new Animal2("Cat");

Console.WriteLine();
Console.WriteLine("Section 39.6: Calling the base class constructor");

new Mammal("George the Cat");


Console.WriteLine();
Console.WriteLine("Section 39.7: Finalizers on derived classes");
new TheDrivedClass();

GC.Collect();

Console.WriteLine();
Console.WriteLine("Section 39.8: Exceptions in static constructor");
try
{
    Animal4.Yawn();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}


try
{
    Animal4.Yawn();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.WriteLine();
Console.WriteLine("Section 39.9: Constructor and Property Initialization");
var testInstance = new TestClass() { TestProperty = 1 };
Console.WriteLine(testInstance.TestProperty);

class Animal
{
    static Animal()
    {
        Console.WriteLine("Animal initialized");
    }

    public Animal()
    {
        Console.WriteLine("Animal created");
    }

    public static void Yamn()
    {
        Console.WriteLine("Yamn!");
    }
}

public class Sessionmanager
{
    public static Sessionmanager instance;

    static Sessionmanager()
    {
        instance = new Sessionmanager();
    }
}


#region Section 39.3: Default Constructor
public class Animal1
{

    public Animal1() { }
    public Animal1(string name) { }
}

public class Creature
{
    public Creature(Genus genus) { }
}

public class Genus { }
#endregion

#region Section 39.5: Calling a constructor from another constructor
public class Animal2
{
    public string Name { get; set; }
    public Animal2() : this("Dog")
    { }

    public Animal2(string name)
    {
        Name = name;
    }
}
#endregion


#region Section 39.6: Calling the base class constructor
public class Animal3
{
    public Animal3() { Console.WriteLine("An unknown animal gets born"); }
    public Animal3(string name) { Console.WriteLine(name + "gets born"); }

}

public class Mammal : Animal3
{
    public Mammal(string name) : base(name)
    {
        Console.WriteLine(name + "is a mammal.");
    }
}
#endregion


#region Section 39.7: Finalizers on derived classes
class TheBaseClass
{
    ~TheBaseClass()
    {
        Console.WriteLine("Base class finalized!");
    }
}

class TheDrivedClass : TheBaseClass
{
    ~TheDrivedClass()
    {
        Console.WriteLine("Drived class finalized!");
    }
}
#endregion


#region Section 39.8: Exceptions in static constructor
public class Animal4
{
    static Animal4()
    {
        Console.WriteLine("Static ctor");
        throw new Exception();
    }

    public static void Yawn() { }
}

#endregion

#region Section 39.9: Constructor and Property Initialization

public class TestClass
{
    public int TestProperty { get; set; } = 2;

    public TestClass()
    {
        if (TestProperty == 1)
        {
            Console.WriteLine("Shal this be executed?");
        }

        if (TestProperty == 2)
        {
            Console.WriteLine("Or shall this be executed");
        }
    }
}
#endregion 
