using System.Collections.Concurrent;

Console.WriteLine("Chapter 38: Nullable types");
Console.WriteLine();
Console.WriteLine("Section 38.1: Initialising a nullable");
Nullable<int> i = null;
int? i1 = null;

var i2 = (int?)null;
// non-null value

Nullable<int> i3 = 0;

int? i4 = 0;

Console.WriteLine();
Console.WriteLine("Section 38.2: Check if a Nullable has a value");
int? i5 = null;

if (i5 != null)
{
    Console.WriteLine("i5 is not null");
}
else
{
    Console.WriteLine("i5 is null");
}

Console.WriteLine();
Console.WriteLine("Section 38.3: Get the value of a nullable type");

int? i6 = 10;

Console.WriteLine("set default value");
int j = i6 ?? 0;
int j1 = i6.GetValueOrDefault(0);
int j2 = i6.HasValue ? i6.Value : 0;

int j3 = i6.Value;

Console.WriteLine(j3);

Console.WriteLine();
Console.WriteLine("Section 38.4: Getting a default value from a nullable");

int? nullableexample = null;
int result = nullableexample.GetValueOrDefault();
Console.WriteLine(result);
int scondResult = nullableexample.GetValueOrDefault(1);
Console.WriteLine(scondResult);
int thirdResult = nullableexample ?? 1;
Console.WriteLine(thirdResult);

Console.WriteLine();
Console.WriteLine("Section 38.5: Default value of nullable types is null");

NullableTypesExample.Main();

Console.WriteLine();
Console.WriteLine("Section 38.6: Eective usage of underlying Nullable<T> argument");

Type type = typeof(int).GetNullable();
Console.WriteLine(type.ToString());

if (type.IsNullable())
    Console.WriteLine("Type is nullable.");

Type underlyingType;
if (type.IsNullable(out underlyingType))
    Console.WriteLine("The undelying type is " + underlyingType.Name + ",");
if (type.IsExactOrNullable<int>())
    Console.WriteLine("type is either exact or nullable Int32.");
if (!type.IsExactOrNullable(t => t.IsEnum))
    Console.WriteLine("Type is neither exact nor nullable enum,");


Console.WriteLine();
Console.WriteLine("Section 38.7: Check if a generic type parameter is a nullable type");


Console.WriteLine(TypesHelper.IsTypeNullable<string>());
Console.WriteLine(TypesHelper.IsTypeNullable<int?>());




public static class TypesHelper
{
    public static bool IsNullable(this Type type)
    {
        Type underlyingType;
        return IsNullable(type, out underlyingType);
    }
    public static bool IsNullable(this Type type, out Type underlyingType)
    {
        underlyingType = Nullable.GetUnderlyingType(type);
        return underlyingType != null;
    }
    public static Type GetNullable(this Type type)
    {
        Type underlyingType;
        return IsNullable(type, out underlyingType) ? type : NullableTypesCache.Get(type);
    }
    public static bool IsExactOrNullable(this Type type, Func<Type, bool> predicate)
    {
        Type underlyingType;
        if (IsNullable(type, out underlyingType))
            return IsExactOrNullable(underlyingType, predicate);
        return predicate(type);
    }
    public static bool IsExactOrNullable<T>(this Type type)
    where T : struct
    {
        return IsExactOrNullable(type, t => Equals(t, typeof(T)));
    }

    public static bool IsTypeNullable<T>()
    {
        return Nullable.GetUnderlyingType(typeof(T)) != null;
    }
}


public class NullableTypesExample
{
    static int? _testValue;

    public static void Main()
    {
        if (_testValue == null)
        {
            Console.WriteLine("null");
        }
        else
        {
            Console.WriteLine(_testValue.ToString());
        }
    }
}

static class NullableTypesCache
{
    readonly static ConcurrentDictionary<Type, Type> cache = new ConcurrentDictionary<Type,
        Type>();
    static NullableTypesCache()
    {
        cache.TryAdd(typeof(byte), typeof(Nullable<byte>));
        cache.TryAdd(typeof(short), typeof(Nullable<short>));
        cache.TryAdd(typeof(int), typeof(Nullable<int>));
        cache.TryAdd(typeof(long), typeof(Nullable<long>));
        cache.TryAdd(typeof(float), typeof(Nullable<float>));
        cache.TryAdd(typeof(double), typeof(Nullable<double>));
        cache.TryAdd(typeof(decimal), typeof(Nullable<decimal>));
        cache.TryAdd(typeof(sbyte), typeof(Nullable<sbyte>));
        cache.TryAdd(typeof(ushort), typeof(Nullable<ushort>));
        cache.TryAdd(typeof(uint), typeof(Nullable<uint>));
        cache.TryAdd(typeof(ulong), typeof(Nullable<ulong>));

    }
    readonly static Type NullableBase = typeof(Nullable<>);
    internal static Type Get(Type type)
    {
        return cache.GetOrAdd(type, t => NullableBase);
    }
}

