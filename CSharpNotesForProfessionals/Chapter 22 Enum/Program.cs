using System.ComponentModel;

namespace Chapter_22_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 22: Enum");

            Console.WriteLine("");
            Console.WriteLine("Section 22.1: Enum basics");

            Day myFavoriteDay = Day.Friday;

            Console.WriteLine($"MY Favorite Day is : {myFavoriteDay}");
            Console.WriteLine($"MY Favorite Day 2 is : {Day.Monday}");

            int myFavoriteDayIndex = (int)myFavoriteDay;

            Console.WriteLine($"My Favorite Day {myFavoriteDay} is No.{myFavoriteDayIndex}");

            Day dayFive = (Day)5;
            Console.WriteLine($"My Favorite Day Nomber 5 is {dayFive}");


            Console.WriteLine();
            Console.WriteLine("Section 22.2: Enum as flags");
            var twoFlags = MyEnum.FlagA | MyEnum.FlagB;
            Console.WriteLine(twoFlags);
            Console.WriteLine(MyEnum.FlagZ);
            Console.WriteLine(BigEnum.BigValue);

            Console.WriteLine();
            Console.WriteLine("Enum as flags number");

            var total = (int)FlagsEnum.Default;

            Console.WriteLine(FlagsEnum.Default);

            Console.WriteLine();
            Console.WriteLine("Chek value enum with HasFlag");
            var value = MyEnum1.One | MyEnum1.Two;

            if (value.HasFlag(MyEnum1.One))
                Console.WriteLine("Enum has One");

            if (value.HasFlag(MyEnum1.Two))
                Console.WriteLine("Enum has Two");

            if (value.HasFlag(MyEnum1.Three))
                Console.WriteLine("Enum has Three");

            Console.WriteLine("Gat all list name enum and hasflag");

            var type = typeof(MyEnum1);
            var names = Enum.GetNames(type);

            foreach (var name in names)
            {
                var item = (MyEnum1)Enum.Parse(type, name);

                if (value.HasFlag(item))
                    Console.WriteLine("Enum has" + name);
            }

            //or 

            foreach (MyEnum1 flagToCheck in Enum.GetValues(typeof(MyEnum1)))
            {
                if (value.HasFlag(flagToCheck))
                {
                    Console.WriteLine("Enum has" + flagToCheck);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Section 22.3: Using << notation for flags");

            Console.WriteLine();
            Console.WriteLine("Section 22.4: Using << notation for flags");

            var value1 = FlagsEnum1.Default;

            bool isOption2And3Set = (value1 & FlagsEnum1.Option2And3) == FlagsEnum1.Option2And3;

            //Assert.True(isOption2And3Set);

            Console.WriteLine();
            Console.WriteLine("Section 22.5: Add and remove values from flagged enum");
            var value3 = MyEnum2.Flag1;
            value3 |= MyEnum2.Flag2;
            value3 |= MyEnum2.Flag3;

            value3 &= ~MyEnum2.Flag2;


            Console.WriteLine();
            Console.WriteLine("Section 22.6: Enum to string and back");

            string thursday = DayOfWeek.Thursday.ToString();

            string seventhDay = Enum.GetName(typeof(DayOfWeek), 6);

            string monday = Enum.GetName(typeof(DayOfWeek), DayOfWeek.Monday);

            DayOfWeek tuesday;

            Enum.TryParse("Tuesday", out tuesday);

            DayOfWeek sunday;
            bool macthFound1 = Enum.TryParse("SUNDAY", out sunday);

            DayOfWeek wednesday;
            bool matchFound2 = Enum.TryParse("WEDNESDAY", true, out wednesday);

            DayOfWeek friday = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Friday");

            //  DayOfWeek caturday = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Caturady");

            string[] weekdays = Enum.GetNames(typeof(DayOfWeek));

            Console.WriteLine(String.Join(',', weekdays));

            Console.WriteLine();
            Console.WriteLine("Section 22.7: Enums can have unexpected values");

            DaysOfWeek d = (DaysOfWeek)31;
            Console.WriteLine(d);

            DaysOfWeek s = DaysOfWeek.Saturday;
            s++; // No error

            Console.WriteLine(Enum.IsDefined(typeof(DaysOfWeek), d));

            Console.WriteLine();
            Console.WriteLine("Section 22.8: Default value for enum == ZERO");
            var e = default(DaysOfWeek);

            if (e == DaysOfWeek.Monday)
                Console.WriteLine("Default to Moday");
            else
                Console.WriteLine("Unknow");

            Console.WriteLine();
            Console.WriteLine("Section 22.9: Adding additional description information to an enum value");

            PossibleResults result = PossibleResults.FileNotFound;
            Console.WriteLine(result);
            Console.WriteLine(GetDescriptionAttribute(result));
            Console.WriteLine("With Extension");
            Console.WriteLine(result.GetDescription());

            Console.WriteLine();
            Console.WriteLine("Section 22.10: Get all the members values of an enum");
            foreach (MyEnum3 en in Enum.GetValues(typeof(MyEnum3)))
            {
                Console.WriteLine(en);
            }

            Console.WriteLine();
            Console.WriteLine("Section 22.11: Bitwise Manipulation using enums");

            var color = Colors.Red | Colors.Blue;
            Console.WriteLine($"Emum color with Flag : {color.ToString()}");

            var color1 = Colors1.Red | Colors1.Blue;
            Console.WriteLine($"Enum color with Flag : {color1.ToString()}");
        }

        public static string GetDescriptionAttribute(PossibleResults result)
        {
            return ((DescriptionAttribute)Attribute.GetCustomAttribute((result.GetType().GetField(result.ToString())), typeof(DescriptionAttribute))).Description;
        }


    }
}