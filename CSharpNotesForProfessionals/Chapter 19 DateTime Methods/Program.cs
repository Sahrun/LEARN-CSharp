using System.Globalization;

namespace Chapter_19_DateTime_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section 19.1: DateTime Formatting");
            DateTime dt = new DateTime(2024, 03, 12, 08, 39, 30, 234);
            Console.WriteLine(String.Format("{0:t}", dt));
            Console.WriteLine(String.Format("{0:d}", dt));
            Console.WriteLine(String.Format("{0:T}", dt));
            Console.WriteLine(String.Format("{0:D}", dt));
            Console.WriteLine(String.Format("{0:f}", dt));
            Console.WriteLine(String.Format("{0:F}", dt));
            Console.WriteLine(String.Format("{0:g}", dt));
            Console.WriteLine(String.Format("{0:G}", dt));
            Console.WriteLine(String.Format("{0:m}", dt));
            Console.WriteLine(String.Format("{0:y}", dt));
            Console.WriteLine(String.Format("{0:r}", dt));
            Console.WriteLine(String.Format("{0:s}", dt));
            Console.WriteLine(String.Format("{0:u}", dt));

            Console.WriteLine();
            Console.WriteLine("Custome datetime formating");

            Console.WriteLine(String.Format("{0:y yy yyy yyyy}", dt));
            Console.WriteLine(String.Format("{0:M MM MMM MMMM}", dt));
            Console.WriteLine(String.Format("{0:d dd ddd dddd}", dt));
            Console.WriteLine(String.Format("{0:h hh H HH}", dt));
            Console.WriteLine(String.Format("{0:m mm}", dt));
            Console.WriteLine(String.Format("{0:s ss}", dt));
            Console.WriteLine(String.Format("{0:f ff fff ffff}", dt));
            Console.WriteLine(String.Format("{0:F FF FFF FFFF}", dt));
            Console.WriteLine(String.Format("{0:t tt}", dt));
            Console.WriteLine(String.Format("{0:z zz zzz}", dt));

            Console.WriteLine();
            Console.WriteLine("Section 19.2: DateTime.AddDays(Double)");
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(36);
            Console.WriteLine("Today : {0:ddd}", today);
            Console.WriteLine("36 days from today: {0:dddd}", answer);

            today = DateTime.Now;
            answer = today.AddDays(-3);
            Console.WriteLine("Today: {0:dddd}", today);
            Console.WriteLine("-3 days from today : {0:dddd}", answer);

            Console.WriteLine();
            Console.WriteLine("Section 19.3: DateTime.AddHours(Double)");
            double[] hours = { .08333, .16667, .25, .33333, .5, .66667, 1, 2, 29, 30, 31, 90, 365 };
            DateTime datetValue = new DateTime(2009, 3, 1, 12, 0, 0);

            foreach (double hour in hours)
            {
                Console.WriteLine("{0} + {1} hour(s) = {2}", datetValue, hour, datetValue.AddHours(hour));
            }

            Console.WriteLine();
            Console.WriteLine("Section 19.4 DateTime.Parse(String)");

            var dateTime = DateTime.Parse("14:23 22 Jul 2016");
            Console.WriteLine(dateTime.ToString());

            Console.WriteLine();
            Console.WriteLine("Section 19.5: DateTime.TryParse(String, DateTime)");
            string[] dateTimeStrings = new[]{
                "4:23 22 Jul 2016",
                "99:23 2x Jul 2016",
                "22/7/2016 14:23:00"
            };

            foreach (var dateString in dateTimeStrings)
            {
                DateTime dateTime1;
                bool wasParsed = DateTime.TryParse(dateString, out dateTime1);
                string result = dateString + (wasParsed ? $"was passed to {dateTime1}" : "can't be parsed to DateTime");
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("Section 19.6: DateTime.AddMilliseconds(Double)");
            string dateFormat = "MM/dd/yyyy hh:mm:ss.fffffff";
            DateTime date1 = new DateTime(2024, 11, 18, 16, 0, 0);
            Console.WriteLine("Original date : {0} ({1:N0} ticks) \n", date1.ToString(dateFormat), date1.Ticks);

            DateTime date2 = date1.AddMicroseconds(1);
            Console.WriteLine("Scond date: {0} ({1:N0} ticks)",
                date2.ToString(dateFormat), date2.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks) \n",
                date2 - date1, date2.Ticks - date1.Ticks);

            DateTime date3 = date1.AddMicroseconds(1.5);
            Console.WriteLine("Third date: {0} ({1:N0} ticks)",
                 date3.ToString(dateFormat), date3.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0}) tiks",
                date3 - date1, date3.Ticks - date1.Ticks);

            Console.WriteLine();
            Console.WriteLine("Section 19.7: DateTime.Compare(DateTime t1, DateTime t2 )");
            date1 = new DateTime(2024, 3, 1, 0, 0, 0);
            date2 = new DateTime(2024, 3, 1, 12, 0, 0);

            int result_compare = DateTime.Compare(date1, date2);
            string relationship;

            if (result_compare < 0)
                relationship = "is earlier then";
            else if (result_compare == 0)
                relationship = "is the same time as";
            else relationship = "is later than";

            Console.WriteLine("{0} {1} {2}", date1, relationship, date2);

            Console.WriteLine();
            Console.WriteLine("Section 19.8: DateTime.DaysInMonth(Int32, Int32)");
            const int July = 7;
            const int Feb = 2;

            int daysInJuly = System.DateTime.DaysInMonth(2024, July);
            Console.WriteLine("Days on month July: {0}", daysInJuly);

            int daysInFeb = System.DateTime.DaysInMonth(1998, Feb);
            Console.WriteLine("Days on month Feb 1998: {0}", daysInJuly);

            int daysInFebLeap = System.DateTime.DaysInMonth(1996, Feb);
            Console.WriteLine("Days on month July 1996: {0}", daysInJuly);

            Console.WriteLine();
            Console.WriteLine("Section 19.9: DateTime.AddYears(Int32)");
            DateTime baseDate = new DateTime(2000, 2, 29);
            Console.WriteLine("Base Date: {0:d}\n", baseDate);
            for (int ctr = -1; ctr >= -15; ctr--)
            {
                Console.WriteLine("{0,2} year(s) ago:{1:d}", ctr, baseDate.AddYears(ctr));
            }

            Console.WriteLine();
            for (int ctr = 1; ctr <= 15; ctr++)
            {
                Console.WriteLine("{0,2} year(s) from now: {1:d}", ctr, baseDate.AddYears(ctr));
            }

            Console.WriteLine();
            Console.WriteLine("Section 19.10: Pure functions warning when dealing with DateTime");

            DateTime sample = new DateTime(2016, 12, 25);
            sample.AddDays(1);
            Console.WriteLine(sample.ToShortDateString());
            sample = sample.AddDays(1);
            Console.WriteLine(sample.ToShortDateString());

            Console.WriteLine();
            Console.WriteLine("Section 19.11: DateTime.TryParseExact(String, String, IFormatProvider, DateTimeStyles, DateTime) ");

            CultureInfo enUS = new CultureInfo("en-US");
            string dateString1;
            System.DateTime dateValue;
            dateString1 = " 5/01/2009 8:30 AM";
            if (DateTime.TryParseExact(dateString1, "g", enUS, DateTimeStyles.None, out dateValue))
                Console.WriteLine("Converted , {0} to {1} ({2}) . ", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);

            Console.WriteLine();

            if (DateTime.TryParseExact(dateString1, "g", enUS, DateTimeStyles.AllowLeadingWhite, out dateValue))
                Console.WriteLine("Converted , {0} to {1} ({2}) . ", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);

            Console.WriteLine();
            dateString1 = "5/01/2009 09:00";
            if (DateTime.TryParseExact(dateString1, "M/dd/yyyy hh:mm", enUS, DateTimeStyles.None, out datetValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);

            Console.WriteLine();
            if (DateTime.TryParseExact(dateString1, "MM/dd/yyyy hh:mm", enUS, DateTimeStyles.None, out dateValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not an accepteble format.", dateString1);

            Console.WriteLine();
            dateString1 = "05/01/2009 01:30:42 PM -05:00";
            if (DateTime.TryParseExact(dateString1, "MM/dd/yyyy hh:mm:ss tt zzz", enUS, DateTimeStyles.None, out dateValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString1, datetValue, datetValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);

            Console.WriteLine();
            if (DateTime.TryParseExact(dateString1, "MM/dd/yyyy hh:mm:ss tt zzz", enUS, DateTimeStyles.AdjustToUniversal, out dateValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);

            Console.WriteLine();
            dateString1 = "2008-06-11T16:11:20.0904778Z";
            if (DateTime.TryParseExact(dateString1, "o", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);

            Console.WriteLine();
            if (DateTime.TryParseExact(dateString1, "o", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString1, dateValue, dateValue.Kind);
            else
                Console.WriteLine("'{0}' is not in an acceptable format.", dateString1);


            Console.WriteLine();
            Console.WriteLine("Section 19.12: DateTime.Add(TimeSpan)");
            today = DateTime.Now;
            TimeSpan duration = new TimeSpan(36, 0, 0, 0);
            answer = today.Add(duration);
            Console.WriteLine("{0:dddd}", answer);

            Console.WriteLine();
            Console.WriteLine("Section 19.13: Parse and TryParse with culture info");
            DateTime dateResult;
            var dutchDateString = "31 october 1999 04:20";
            var dutchCulture = CultureInfo.CreateSpecificCulture("nl-NL");
            if (DateTime.TryParse(dutchDateString, dutchCulture, DateTimeStyles.None, out dateResult))
                Console.WriteLine(dateResult);

            Console.WriteLine();
            Console.WriteLine("Section 19.14: DateTime as initializer in for-loop");
            DateTime start = new DateTime(2016, 01, 01);
            DateTime until = new DateTime(2016, 02, 01);

            for (DateTime d_t = start; d_t < until; d_t = d_t.AddDays(1))
            {
                Console.WriteLine("Added {0} days. Resulting Date: {1}", (d_t - start).Days, d_t.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Section 19.15: DateTime.ParseExact(String, String, IFormatProvider)");
            string str = "08-07-2016 11:30:12 PM";
            DateTime date = DateTime.ParseExact(str, "MM-dd-yyyy hh:mm:ss tt", CultureInfo.CurrentCulture);
            Console.WriteLine("Date : {0}", date.ToString("dd-MM-yyyy hh:mm:ss tt"));
            str = "17-06-16 11:30:12 PM";
            date = DateTime.ParseExact(str, "dd-MM-yy hh:mm:ss tt", CultureInfo.InvariantCulture);
            Console.WriteLine("Date : {0}", date.ToString("dd-MM-yyyy hh:mm:ss tt"));

            string dt_string = "12/23/2016";
            string[] format = new string[] { "dd-MM-yyyy", "MM/dd/yyyy" };
            date = DateTime.ParseExact(dt_string, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
            Console.WriteLine("Date : {0}", date.ToString("dd-MM-yyyy hh:mm:ss tt"));

            Console.WriteLine();
            Console.WriteLine("Section 19.16: DateTime ToString, ToShortDateString,\r\nToLongDateString and ToString formatted");
            var dt_date = new DateTime(2016, 12, 31);
            Console.WriteLine("Output : {0}", dt_date.ToString());
            Console.WriteLine("Output : {0}", dt_date.ToShortDateString());
            Console.WriteLine("Output : {0}", dt_date.ToLongDateString());
            Console.WriteLine("Output : {0}", dt_date.ToString("dd/MM/yyyy"));

            Console.WriteLine();
            Console.WriteLine("Section 19.17: Current Date");
            Console.WriteLine("Output: {0}", DateTime.Today);
        }
    }
}