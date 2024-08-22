

using Chapter_48_Extension_Methods_overview;
using Chapter_48_Extension_Methods_Section_48_10;
using Chapter_48_Extension_Methods_Section_48_11;
using Chapter_48_Extension_Methods_Section_48_12;
using Chapter_48_Extension_Methods_Section_48_13;
using Chapter_48_Extension_Methods_Section_48_14;
using Chapter_48_Extension_Methods_Section_48_15;
using Chapter_48_Extension_Methods_Section_48_16;
using Chapter_48_Extension_Methods_Section_48_17;
using Chapter_48_Extension_Methods_Section_48_2_Null_checking;
using Chapter_48_Extension_Methods_Section_48_3_Explicitly_using_an_extension_method;
using Chapter_48_Extension_Methods_Section_48_4_Generic_Extension_Methods;
using Chapter_48_Extension_Methods_Section_48_6;
using Chapter_48_Extension_Methods_Section_48_7;
using Chapter_48_Extension_Methods_Section_48_8;
using System.Dynamic;
using System.Runtime.Caching;

Console.WriteLine("Chapter 48: Extension Methods");


Console.WriteLine();
Console.WriteLine("Section 48.1: Extension methods - overview");

// This call method Stirng.ToUpper()
var myString = "Hhello Word!".ToUpper();

// This call the extension method StringExtensions.Shorten()
var newString = myString.Shorten(5);

Console.WriteLine("Call extension 1 : {0}", newString);

// It is worth noting that the above call is purely syntactic sugar
// and the assignment below is functionally equivalent

var newString2 = StringExtensions.Shorten(myString, 5);

Console.WriteLine("Call extension 2 : {0} ", newString2);

// Call instance extension

"some string".Shorten(5);


// Method extension from linq
var ints = new int[] { 1, 2, 3 };

var even = ints.Where(i => i % 2 == 0);



Test t = new Test();
t.Hello();


//Calling as though method belongs to string--it seamlessly extends string
String s = "Hello World";
s.Shorten(5);
//Calling as a traditional static method with two parameters
StringExtensions.Shorten(s, 5);


Console.WriteLine("Section 48.2: Null checking");


string nullStirng = null;
string emptyString = nullStirng.EmptyIfNull(); // will retun "";
Console.WriteLine("Null checking 1 : {0}", emptyString);
string anotherNullString = emptyString.NullIfEmpty(); // will return null
Console.WriteLine("Null checking 1 : {0}", anotherNullString);

Console.WriteLine();

Console.WriteLine("Section 48.3: Explicitly using an extension method\r\n");

var newString3 = StirngExtensions2.Shorten2("Hello Word", 5);

Console.WriteLine("Section 48.4: Generic Extension Methods");

// generic
IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

var hasMoreThanThreeElements = numbers.HasMoreThanThreeElements();

IEnumerable<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6 };
var result = numbers.GenericExt<IEnumerable<int>, string>();

Mytype<int, string> t1 = new Mytype<int, string>();

t1.Example();
// with where 
int number = 5;

var IsDefault = number.IsDefault();


Console.WriteLine("");
Console.WriteLine("Section 48.6: Extension methods for chaining");
int resultInt = 5.Increment().Decrement().Increment();
Console.WriteLine("Result Inc,Dec,Inc : {0}", resultInt);

int[] ints1 = new[] { 1, 2, 3, 4, 5, 6 };
int[] a = ints1.WhereEven();
int[] b = ints1.WhereEven().WhereGreaterThen(2);

Console.WriteLine("Result1 : {0} , Result2: {1}", String.Join(',', a), String.Join(',', b));


Console.WriteLine();
Console.WriteLine("Section 48.7: Extension methods with Enumeration");
bool yesNoBoll = YesNo.Yes.ToBool(); // true
YesNo yesNoEnum = false.ToYesNo(); // YesNo.No

var massWater = 2 * Element.Hydrogenn.AntomicMass() + Element.Oxygen.AntomicMass();


Console.WriteLine();
Console.WriteLine("Section 48.8: Extension methods dispatch based on static type");
Derived derived = new Derived();
Base @base = derived;

// Use the intance method "Getname"
Console.WriteLine(derived.GetName()); // Prints "Derived"
Console.WriteLine(@base.GetName());   // Prints "Derived"

// Use the static extension method "GetnameByExtension"
Console.WriteLine(derived.GetnameByExtension()); // Printes "Derived"
Console.WriteLine(@base.GetnameByExtension());   // Prints "Base"


dynamic person = new Person { Name = " Jon" };

//var name = person.GetPersonName(); //  RuntimeBinderException is thrown


Console.WriteLine();
Console.WriteLine("Section 48.10: Extension methods in combination with\r\ninterfaces");
var classy = new Classy();

classy.Do(); // will call the extension
classy.DoWhite(); // Classy implements IInterface so it can also be called this way


Console.WriteLine();
Console.WriteLine("Section 48.11: Extension methods aren't supported by\r\ndynamic code");
dynamic dynamicObject = new ExpandoObject();

string awesomeString = "Awesome";

// Prints true
Console.WriteLine(awesomeString.IsThisAwesome());

// No compile time error or warning, but on runtime throws RuntimeBinderException
//Console.WriteLine(dynamicObject.StringValue.IsThisAwesome());


Console.WriteLine();
Console.WriteLine("Section 48.12: Extensions and interfaces together enable DRY\r\ncode and mixin-like functionality");

var formatter = new SecondsTimeFormatter();
// Callers get two method overloades!
Console.WriteLine($"4500ms is rougly {formatter.Format(4500)}");
var span = TimeSpan.FromSeconds(5);
Console.WriteLine($"{span} is formatted as {formatter.Format(span)}");

Console.WriteLine();
Console.WriteLine("Section 48.13: IList<T> Extension Method Example: Comparing\r\n2 Lists\r\n");

List<string> list1 = new List<string> { "a1", "a2", null, "a3" };
List<string> list2 = new List<string> { "a1", "a2", "a3", null };

Console.WriteLine($"List1 & List2 is same: {list1.Compare(list2)}");
Console.WriteLine($"List1 & List2 is same: {list1.Compare(list2, false)}");

Console.WriteLine();
Console.WriteLine("Section 48.14: Extension methods as strongly typed wrappers");

var cache = new MemoryCache("UserInfo");

cache.SetuserInfo(new UserInfo());
var userInfo = cache.GetUserInfo();

Console.WriteLine();
Console.WriteLine("Section 48.15: Using Extension methods to create beautiful\r\nmapper classes");

UserDTO userDTOObj = new UserDTO
{
    Address = new AddressDTO
    {
        Name = "Address of the user"
    }
};

UserViewModel userVW = userDTOObj.ToViewModel();

Console.WriteLine("Address : {0}", userVW.address.Name);


Console.WriteLine();
Console.WriteLine("Section 48.16: Using Extension methods to build new collection\r\ntypes (e.g. DictList)");

var dictList = new Dictionary<string, List<int>>();

dictList.Add("example", 5);
dictList.Add("example", 10);
dictList.Add("example", 15);

Console.WriteLine(String.Join(", ", dictList["example"])); // 5, 10, 15

dictList.Remove("example", 5);
dictList.Remove("example", 10);

Console.WriteLine(String.Join(", ", dictList["example"])); // 15

dictList.Remove("example", 15);

Console.WriteLine(dictList.ContainsKey("example")); // False

Console.WriteLine();
Console.WriteLine("Section 48.17: Extension methods for handling special cases");


//Cake myCake = Bakery.GetNextCake().EnsureTrueCake();
//myMouth.Eat(myCake);//Eat the cake, confident that it is not a lie


Console.WriteLine();
Console.WriteLine("Section 48.18: Using Extension methods with Static methods\r\nand Callbacks");
