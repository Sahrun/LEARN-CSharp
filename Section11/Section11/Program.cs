using Section11.Section_11._13_Determine_whether_a_string_begins_with_a_given;
using Section11.Section_11._9_Formatting_using_ToString;
using Section12.Section_11._4Getting_x_characters_from_the_right_side_of_a;
using Section12.Section11._2Correctlyreversingastring;
using Section12.Section11._3Paddingastringtoafixedlength;
using System.Security.Cryptography.X509Certificates;

namespace Section12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Les Mise\u0301rables";
            StringReverse.ReverseStringAndView(s);

            string padString = "Food";

            PaddingString.Show(padString, "L", 4);
            PaddingString.Show(padString, "L", 5, 'E');
            PaddingString.Show(padString, "R", 8, 'X');


            // extension read charakter string

            string myString = "Hello Word, I am Happy";
            Console.WriteLine(myString.Right(6));
            Console.WriteLine(myString.Left(5));
            Console.WriteLine(myString.Left(4));
            Console.WriteLine(myString.Mid(2, 3));


            Console.WriteLine(" ");
            Console.WriteLine(" === ");
            Console.WriteLine("Section 11.9: Formatting using ToString");
            Console.WriteLine(" * Int to string formate* ");
            FormatStringUsingToString.TStringFormate(10, "0000");
            FormatStringUsingToString.TStringFormate(10, "Input value is 0");

            Console.WriteLine(" * Double to string * formate");
            double doubleValue = 10.456;
            // 0 => wajib
            // # => optional
            FormatStringUsingToString.TStringFormate(doubleValue, "0.00");
            FormatStringUsingToString.TStringFormate(doubleValue, "00");
            FormatStringUsingToString.TStringFormate(doubleValue, "Input value is 0.0");
            decimal decimalValue = 10456790.980m;
            FormatStringUsingToString.TStringFormate(decimalValue, "#,###.#00");

            Console.WriteLine(" * Datetime to string formate * ");
            DateTime datetimeValue = DateTime.Now;
            FormatStringUsingToString.TStringFormate(datetimeValue, "dd-MM-yyyy HH;mm:ss");
            FormatStringUsingToString.TStringFormate(datetimeValue, "dd-MM-yyyy");
            FormatStringUsingToString.TStringFormate(datetimeValue, "dd-MMM-yyyy HH:mm:ss");

            Console.WriteLine();
            Console.WriteLine(" * Containt&start string * ");
            string valueString = "Hello word baby";
            StartWithandContainString.CheckStartString(valueString, "Hello");
            StartWithandContainString.CheckEndString(valueString, "baby");
            StartWithandContainString.CheckContainString(valueString, "ello");


            Console.WriteLine();
            Console.WriteLine(" * Concatenation * ");
            string first = "Hello";
            string second = "Word";

            string concat = first + second;
            concat = String.Concat(first, second);
            concat = $"{first},{second}";



        }
    }
}