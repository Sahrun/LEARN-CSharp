using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_39
    {
        public Section_66_39()
        {
            List<string> trees = new List<string>() { "Oak", "Birch", "Beech", "Elm", "Hazel", "Maple" };

            IEnumerable<string> initials  = trees.Select(t => t.Substring(0,1));
            foreach (string s in initials) 
                Console.WriteLine(s);
            
            initials = from tree in trees
                       select tree.Substring(0,1);

            foreach (string s in initials)
                Console.WriteLine(s);
        }
    }
}
