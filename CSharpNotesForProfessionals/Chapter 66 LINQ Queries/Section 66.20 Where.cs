using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_20
    {
        public Section_66_20()
        {
            List<string> trees = new List<string> { "Oak", "Birch", "Beech", "Elm", "Hazel", "Maple" };

            var shortTrees = trees.Where(tree => tree.Length == 3);

             shortTrees = from tree in trees
                          where tree.Length == 3
                          select tree;

        }
    }
}
