namespace Chapter_16_String_Escape_Sequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 16: String Escape Sequences");
            Console.WriteLine();
            Console.WriteLine("Section 16.1: Escaping special symbols in string literals");
            string filename = "c:\\myfile.text";
            string filename1 = @"c:\myfile.text";
            Console.WriteLine("Result without @ {0} , With @ {1}", filename, filename1);

            string text = "\"Hello World!\", said the quick brown fox. ";
            Console.WriteLine("String With Quotes without @ {0}", text);
            text = @"""Hello World!"", said the quick brown fox.";
            Console.WriteLine("String With Quotes with @ {0}", text);

            text = "Hello\r\nWorld!";
            Console.WriteLine("String NewLine without @ {0}", text);
            text = @"Hello 
                   World!";
            Console.WriteLine("String NewLine with @ {0}", text);

            Console.WriteLine();
            Console.WriteLine("Section 16.2: Unicode character escape sequences");
            text = "\\U221A";
            Console.WriteLine("Simbol centang: {0}", text);
            text = "\\U0001F601";
            Console.WriteLine("Contoh Emoji: {0}", text);
            text = "\\u0022Hello World\\u0022";
            Console.WriteLine("Contoh double quotes escape sequence Unicode: {0}", text);
            text = "\\x22Hello World\\x22";
            Console.WriteLine("Contoh double quotes escape sequence hexadecimal : {0}", text);




        }
    }
}