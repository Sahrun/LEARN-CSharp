namespace Chapter_14_String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section 14.1: Replacing a string within a string");
            string s = "Hello World";
            Console.WriteLine(s.Replace("Word", "Universe"));

            Console.WriteLine(s.Replace("l", "L"));
            Console.WriteLine(s.Replace("ell", string.Empty));

            Console.WriteLine("Section 14.2: Finding a string within a string");
            bool stringExists = s.Contains("ello");
            Console.WriteLine("Sentence {0} contain word ello : {1}", s, stringExists);

            int location = s.IndexOf("ello");
            Console.WriteLine("Location index on : {0}", location);

            location = s.LastIndexOf("l");
            Console.WriteLine("Last Index on : {0}", location);

            Console.WriteLine();
            Console.WriteLine("Section 14.3: Removing (Trimming) white-space from a string");
            s = "     String with spaces at both ends    ";

            Console.WriteLine(s.TrimStart());
            Console.WriteLine(s.TrimEnd());
            Console.WriteLine(s.Trim());

            s = "A portion of word that is retained";
            Console.WriteLine(s.Substring(26));
            Console.WriteLine(s.Substring(0, 5));

            Console.WriteLine();
            Console.WriteLine("Section 14.4: Splitting a string using a delimiter");
            string sentence = "One Two Three Fo,ur";
            string[] stringArray = sentence.Split(new char[] { ' ', ',' });

            foreach (string word in stringArray)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.WriteLine("Section 14.5: Concatenate an array of strings into a single string");
            string[] words = { "One", "Two", "Three", "Four" };
            Console.WriteLine(String.Join(",", words));

            Console.WriteLine();
            Console.WriteLine("Section 14.6: String Concatenation");
            string first = "Hello";
            string second = "World";
            Console.WriteLine(string.Concat(first, second));


            Console.WriteLine();
            Console.WriteLine("Section 14.7: Changing the case of characters within a String");
            s = "My String";
            Console.WriteLine(s.ToLowerInvariant());
            Console.WriteLine(s.ToUpperInvariant());
        }
    }
}