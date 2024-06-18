using Chapter12.Section_12._3_Create_a_custom_format_provider;
using Chapter12.Section_12._9_ToString__;
using System.Globalization;

namespace Chapter12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Chapter 12 ---");
            Console.WriteLine(" * Section 12.3: Create a custom format provider * ");
            Console.WriteLine(String.Format(new CustomFormat(), "-> {0:Reverse} <-", "Hello World"));

            Console.WriteLine();
            Console.WriteLine(" * Section 12.4: Date Formatting * ");

            DateTime datenow = new DateTime(2024, 02, 03, 21, 42, 00);
            Console.WriteLine(String.Format("{0:dd}", datenow));
            Console.WriteLine(String.Format(new System.Globalization.CultureInfo("mn-MN"), "{0:dddd}", datenow));
            Console.WriteLine($"{datenow:ddd}");

            Console.WriteLine();
            Console.WriteLine("Section 12.5: Currency Formatting");
            double price = 112.127766;
            Console.WriteLine(string.Format("{0:c}", price));
            Console.WriteLine(string.Format("{0:c1}", price));
            Console.WriteLine(string.Format("{0:c3}", price));
            Console.WriteLine(string.Format("{0:c4}", price));
            Console.WriteLine(string.Format("{0:c9}", price));

            Console.WriteLine(string.Format(new CultureInfo("en-ID"), "{0:c}", price));
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:C}", price));
            Console.WriteLine(string.Format(new CultureInfo("sk-SK"), "{0:C}", price));
            Console.WriteLine(string.Format(new CultureInfo("hi-IN"), "{0:C}", price));

            // custome simbol
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();
            nfi.CurrencySymbol = "?";

            Console.WriteLine(string.Format(nfi, "{0:C}", price));
            nfi.CurrencySymbol = "?%^&";
            Console.WriteLine(string.Format(nfi, "{0:C}", price));
            nfi.CurrencySymbol = "Rp. ";
            Console.WriteLine(string.Format(nfi, "{0:C}", price));

            // position of currency symbol

            //nfi = new CultureInfo("en-US",false).NumberFormat;
            nfi.CurrencyPositivePattern = 0;
            Console.WriteLine(string.Format(nfi, "{0:C}", price));
            nfi.CurrencyPositivePattern = 1;
            Console.WriteLine(string.Format(nfi, "{0:C}", price));
            nfi.CurrencyPositivePattern = 2;
            Console.WriteLine(string.Format(nfi, "{0:C}", price));
            nfi.CurrencyPositivePattern = 3;
            Console.WriteLine(string.Format(nfi, "{0:C}", price));
            //nfi.CurrencyPositivePattern = 4;
            //Console.WriteLine(string.Format(nfi, "{0:C}", price));

            // Custome decimal sparator
            nfi.CurrencyPositivePattern = 0;
            nfi.CurrencyDecimalSeparator = "..";
            Console.WriteLine(string.Format(nfi, "{0:C}", price));


            Console.WriteLine("Section 12.6: Using custom number format");
            price = 1234567.89;
            var invarianResult = string.Format(CultureInfo.InvariantCulture, "{0:#,###.##}", price);
            Console.WriteLine(invarianResult);

            // with class NumberFormatInfo
            var customProvaider = new NumberFormatInfo
            {
                NumberDecimalSeparator = "_NS_", // will be used instead of ','
                NumberGroupSeparator = "_GS_" // will be used instead of '.'
            };


            Console.WriteLine(String.Format(customProvaider, "{0:#,###.##}", price));

            Console.WriteLine();
            Console.WriteLine("Section 12.7: Align left/ right, pad with spaces");
            Console.WriteLine("LEFT: string: ->{0,-5}<- int: ->{1,-5}<-", "abc", 123);
            Console.WriteLine("RIGHT: string: ->{0,5}<- int: ->{1,5}<-", "abc", 123);


            Console.WriteLine();
            Console.WriteLine("Section 12.8: Numeric formats");
            // Integral type as hex
            Console.WriteLine(string.Format("Hexadecimal: byte2: {0:x2};  byte4: {0:x4}; char: {1:x2}", 123, (int)'A'));
            // Integer with thousand separators
            Console.WriteLine(string.Format("Integer, thousand sep.: {0:#,#}; fixed length: >{0,10:#,#}<", 1234567));
            // Integer with leading zeroes
            Console.WriteLine(string.Format("Integer, leading zeroes: {0:00}; ", 1));
            // Decimals
            Console.WriteLine("Decimal, fixed precision: {0:0.00}; as percents: {0:0.00%}", 0.12);

            Console.WriteLine();
            Console.WriteLine("Section 12.9: ToString()");

            var user = new User { Name = "User1", Id = 5 };
            Console.WriteLine(user.ToString());


            Console.WriteLine();
            Console.WriteLine("Section 12.10: Escaping curly brackets inside a String.Format() expression");
            string outsidetext = "I am outside of bracket";
            Console.WriteLine(string.Format("{{I am in brackets!}} {0}", outsidetext));

            Console.WriteLine();
            Console.WriteLine("Section 12.11: Relationship with ToString()");
            Console.WriteLine(string.Format("Intance : {0:C}", price));
            Console.WriteLine($"Intance with to string : {price.ToString("C")}");
            Console.WriteLine(string.Format("With Left : {0,10:C}", price));
            Console.WriteLine($"With method pdleft : {price.ToString("C").PadLeft(15)}");


        }
    }
}