using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_71_C__7._0_Features
{
    public class Section_71_2
    {
        public Section_71_2()
        {
            Console.WriteLine("CylinderVolum for 35,8 and height 7,8 : {0}", GetCylinderVolume(35.8, 7.8));
        }

        double GetCylinderVolume(double radius, double height)
        {
            return getVolume();
            double getVolume()
            {
                // You can declare inner-local functions in a local function
                double GetCircleArea(double r) => Math.PI * r * r;
                // ALL parents' variables are accessible even though parent doesn't have any input.
                return GetCircleArea(radius) * height;
            }
        }

        async Task WriteEmailsAsync()
        {
            var emailRegex = new Regex(@"(?i)[a-z0-9_.+-]+@[a-z0-9-]+\.[a-z0-9-.]+");
            IEnumerable<string> emails1 = await getEmailsFromFileAsync("input1.txt");
            IEnumerable<string> emails2 = await getEmailsFromFileAsync("input2.txt");
            await writeLinesToFileAsync(emails1.Concat(emails2), "output.txt");
            async Task<IEnumerable<string>> getEmailsFromFileAsync(string fileName)
            {
                string text;
                using (StreamReader reader = File.OpenText(fileName))
                {
                    text = await reader.ReadToEndAsync();
                }
                return from Match emailMatch in emailRegex.Matches(text) select emailMatch.Value;
            }
            async Task writeLinesToFileAsync(IEnumerable<string> lines, string fileName)
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    foreach (string line in lines)
                    {
                        await writer.WriteLineAsync(line);
                    }
                }
            }
        }

    }

    public static class loaclFunction
    {
        public static IEnumerable<TSource> Where<TSource>(
         this IEnumerable<TSource> source,
         Func<TSource, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));
            return iterator();
            IEnumerable<TSource> iterator()
            {
                foreach (TSource element in source)
                    if (predicate(element))
                        yield return element;
            }
        }
    }
}
