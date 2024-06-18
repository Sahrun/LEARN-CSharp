using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operators.Section3._18typeof;
using Operators.Section3._2OverloadingEqualityOperators;
using Operators.Section3._4ImplicitCastandExplicitCastOperators;
using Operators.Section6._2DefaultEqualsbehavior;
using Operators.Section6._3OverrideEqualsandGetHashCodeoncustom;
using System.Drawing;

namespace Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex() { Real = 1, Imaginary = 2 };
            Complex b = new Complex() { Real = 4, Imaginary = 8 };
            Complex c = a + b;

            Console.WriteLine($"{c.Real},{c.Imaginary}");


            //var c = Cartesian(3, 4);
            //if (c is Polar(var R, *))
            //{
            //    Console.WriteLine(R);
            //}



            Console.WriteLine("Section 3.2: Overloading equality operators");

            Student student = new Student();

            Student objA = new Student();

            var same = objA == student; //student.Equals(objA);

            Console.WriteLine($"Object ini sama : {same}");

            objA.Name = "Joko";

            same = student.Equals(objA);

            Console.WriteLine($"Object ini sama : {same}");

            student.Name = "Joko1";


            same = student.Equals(objA);

            Console.WriteLine($"Object ini sama : {same}");


            Console.WriteLine("Section 3.4: Implicit Cast and Explicit Cast Operators");

            var binaryImage = new BinaryImage();
            ColorImage colorImage = binaryImage;
            bool[] pixels = (bool[])binaryImage;


            Console.WriteLine("Section 3.18: typeof");

            System.Type type = typeof(Point);
            Console.WriteLine($"Info : {type}");
            type = typeof(IDisposable);
            Console.WriteLine($"Info : {type}");
            type = typeof(SystemColors);
            Console.WriteLine($"Info : {type}");
            type = typeof(List<>);
            Console.WriteLine($"Info : {type}");

            var animal = new Dog();

            //Assert.IsTrue(animal.GetType() == typeof(Animal));
            Assert.IsTrue(animal.GetType() == typeof(Dog));
            Assert.IsTrue(animal is Animal);

            Console.WriteLine("====== Section 6.2: Default Equals behavior ====== ");
            DefaultEqualsbehavior defaultEqualsbehavior = new DefaultEqualsbehavior();


            Console.WriteLine(" ===== Section 6.3: Override Equals and GetHashCode on custom types ======");
            OverrideEqualsandGetHashCodeoncustom overrideEqualsandGetHashCodeoncustom = new OverrideEqualsandGetHashCodeoncustom();


        }
    }
}