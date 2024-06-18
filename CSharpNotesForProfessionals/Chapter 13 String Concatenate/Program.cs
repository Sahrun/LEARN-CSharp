using System.Text;

namespace Chapter_13_String_Concatenate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section 13.1: + Operator");

            string s1 = "string1";
            string s2 = "string2";

            Console.WriteLine(s1 + s2);

            Console.WriteLine();
            Console.WriteLine("Section 13.2 Concatenate strings using System.Text.StringBuilder");
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());

            Console.WriteLine();
            Console.WriteLine("Section 13.3: Concat string array elements using String.Join");
            string[] value = { "apple", "orange", "grape", "pear" };
            string sparator = ", ";
            Console.WriteLine(String.Join(sparator, value, 1, 2));
            Console.WriteLine(String.Join(sparator, value));

            Console.WriteLine();
            Console.WriteLine("Section 13.4: Concatenation of two strings using $");
            var str1 = "Text1";
            var str2 = " ";
            var str3 = "text3";

            Console.WriteLine($"{str1}{str2}{str3}");



        }
    }
}