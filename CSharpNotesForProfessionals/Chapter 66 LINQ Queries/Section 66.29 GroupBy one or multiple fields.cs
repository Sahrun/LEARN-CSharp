using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_29
    {
        public Section_66_29()
        {
            var filems = new List<Film>();

            foreach (var film in filems.GroupBy(x => x.Category))
            {
                var groupCategory = film.Key;
                var numberOfFilemByCaegoey = film.Count();
            }
            foreach (var grp in filems.GroupBy(x => new { Category = x.Category, Year = x.Year }))
            {
                var groupCategory = grp.Key.Category;
                var groupYear = grp.Key.Year;
                var groupCount = grp.Count();
            }
        }
    }

    public class Film
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
    }
}
