// See https://aka.ms/new-console-template for more information
Console.WriteLine("Chapter 49: Named Arguments");
Console.WriteLine();
Console.WriteLine("Section 49.1: Argument order is not necessary");


Console.WriteLine(Sample(left: "A", right: "B"));
Console.WriteLine(Sample(left: "A", right: "B"));


Console.WriteLine();
Console.WriteLine("Section 49.2: Named arguments and optional parameters");
var result = SmsUtil.SendMessage(
    from: "Cihan",
    to: "Yakar",
    message: "hello there!",
    attachment: new object()
    );


Console.WriteLine();
Console.WriteLine("Section 49.3: Named Arguments can make your code more\r\nclear");
result = SmsUtil.SendMessage("Mehran", "Maryam", "Hello there!", 12, null);




static string Sample(string left, string right)
{
    return string.Join("-", left, right);
}

sealed class SmsUtil
{
   public static bool SendMessage(string from, string to, string message, int retryCount = 5, object attachment = null)
    {
        return true;
    }
}