namespace Chapter_31_Value_type_vs_Reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 31: Value type vs Reference type");
            Console.WriteLine();
            Console.WriteLine("Section 31.1: Passing by reference using ref keyword");
            Console.WriteLine();
            int a = 20;
            Console.WriteLine("Inside Main - Before Callee : ={0}", a);
            Callee(a);
            Console.WriteLine("Inside Main - After Callee: a = {0}", a);

            Console.WriteLine("Inside Main - Before CalleeRef: a = {0}", a);
            CalleeRef(ref a);
            Console.WriteLine("Inside Main - After CallleeRef: a = {0}", a);

            Console.WriteLine("Inside Main - Before CalleeOut: a = {0}", a);
            CalleeOut(out a);
            Console.WriteLine("Inside Main - After CalleeOut: a = {0}", a);

            Console.WriteLine();
            Console.WriteLine("Section 31.2: Changing values elsewhere");


            var studentList = new List<Student>();
            studentList.Add(new Student("Scott", "Nuke"));
            studentList.Add(new Student("Vincent", "King"));
            studentList.Add(new Student("Craig", "Bertt"));

            var printingList = studentList;

            studentList[0].LastName = "Duke";
            studentList[1].LastName = "Kong";
            studentList[2].LastName = "Brett";

            PrintPrintingList(studentList);

            Console.WriteLine();
            Console.WriteLine("Section 31.3: ref vs out parameters");
            int a_ = 20;
            Console.WriteLine("Inside Main - Before Callee: a ={0}", a_);
            Callee(a_);
            Console.WriteLine("Inside Main - After Callee: a = {0}", a_);
            Console.WriteLine();

            Console.WriteLine("Inside Main - Before CalleeRef: a ={0}", a_);
            CalleeRef(ref a_);
            Console.WriteLine("Inside Main - After CalleeRe: a = {0}", a_);
            Console.WriteLine();

            Console.WriteLine("Inside Main - Before CalleeOut: a = {0}", a_);
            CalleeOut(out a_);
            Console.WriteLine("Inside Main - After CalleeOut: a = {0}", a_);
            //  Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Section 31.4: Assignment");

            var aL = new List<int>();
            var bL = aL;

            aL.Add(5);

            Console.WriteLine(aL.Count);
            Console.WriteLine(bL.Count);

            bL.Add(5);

            Console.WriteLine(bL.Count);
            Console.WriteLine(aL.Count);


            Console.WriteLine();
            Console.WriteLine("Section 31.5: Difference with method parameters ref and out");
            Console.WriteLine();

            var p = new Program();
            p.TestOut();
            p.TestRef();

            Console.WriteLine();
            Console.WriteLine("Section 31.6: Passing by reference");
            Console.WriteLine();

            int number = 4;
            var valid = DoubleNumber(ref number);
            Console.WriteLine(number);

            valid = DoubleNumberOut(out var outNumber);
            Console.WriteLine(outNumber);


        }
        static void Callee(int a)
        {
            a = 5;
            Console.WriteLine("Inside Callee a : {0}", a);
        }
        static void CalleeRef(ref int a)
        {
            a = 6;
            Console.WriteLine("Inside CalleeRef a : {0}", a);
        }

        static void CalleeOut(out int a)
        {
            a = 7;
            Console.WriteLine("Inside CalleeOut a : {0}", a);
        }

        private static void PrintPrintingList(List<Student> students)
        {

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

        }
        public void ByRef(ref int value)
        {
            Console.WriteLine(nameof(ByRef) + value);
            value += 4;
            Console.WriteLine(nameof(ByRef) + value);
        }

        public void ByOut(out int value)
        {
            //value += 4;
            //Console.WriteLine(nameof(ByOut) + value);
            value = 4;
            Console.WriteLine(nameof(ByOut) + value);

        }

        public void TestOut()
        {
            int intValue1;
            ByOut(out intValue1);

            int intValue2 = 10;
            ByOut(out intValue2);
        }

        public void TestRef()
        {
            //int intValue1;
            //ByRef(ref intValue1);

            int intValue2 = 0;
            ByRef(ref intValue2);

            int intValue3 = 10;
            ByRef(ref intValue3);
        }
        static bool DoubleNumber(ref int number)
        {
            number += number;

            return true;

        }

        static bool DoubleNumberOut(out int number)
        {
            number = 100;

            return true;
        }
    }



    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}