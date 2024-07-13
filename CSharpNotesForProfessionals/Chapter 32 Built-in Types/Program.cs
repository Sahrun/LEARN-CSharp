
Console.WriteLine("Chapter 32: Built-in Types");

object boxedInt = (int)1;

//long unboxedInt1 = (long)boxedInt;

long unboxedInt2 = (long)(int)boxedInt;

Console.WriteLine();
Console.WriteLine("Section 32.2: Comparisons with boxed value types");

object left = (int)1;
object right = (int)1;

var comparasion1 = left == right;

var comparasion2 = left.Equals(right);

var comparasion3 = (int)left == (int)right;


Console.WriteLine();
Console.WriteLine("Section 32.3: Immutable reference type - string");

//string s = "hello";

char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
string s = new string(chars, 0, chars.Length);

//string s;
//unsafe
//{
//    fixed (char* charPointer = "Hello")
//    {
//        s = new string(charPointer);
//    }
//}

Console.WriteLine();
Console.WriteLine("Section 32.4: Value type - char");
char c = 's';
char c1 = (char)115;
char c2 = '\u0073';
char c3 = '\u263a';

Console.WriteLine(c3);

Console.WriteLine();
Console.WriteLine("Section 32.5: Value type - short, int, long (signed 16 bit, 32 bit,64 bit integers)");

short sht = -32768;

short sht1 = 32767;

int i = -2147483648;

int i1 = 2147483647;

long l = -9223372036854775808L;

long l1 = 9223372036854775807L;

Console.WriteLine();
Console.WriteLine("Section 32.6: Value type - ushort, uint, ulong (unsigned 16 bit,32 bit, 64 bit integers)");
ushort sh = 0;
ushort sh1 = 65535;
uint ui = 0;
uint ui1 = 4294967295;
ulong ul = 0UL;
ulong ul1 = 18446744073709551615UL;

Console.WriteLine();
Console.WriteLine("Section 32.7: Value type - bool");
bool b;
bool? z;
b = true;
if (b)
{
    Console.WriteLine("Boolean has true value");
}