using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_48
    {
        public Section_66_48()
        {
            //            Get the "row number" of the items
            //var rowNumbers = collection.OrderBy(item => item.Property1)
            // .ThenBy(item => item.Property2)
            // .ThenByDescending(item => item.Property3)
            // .Select((item, index) => new { Item = item, RowNumber = index })
            // .ToList();
            //            Get the rank of an item within its group
            //            var rankInGroup = collection.GroupBy(item => item.Property1)
            //             .OrderBy(group => group.Key)
            //             .SelectMany(group => group.OrderBy(item => item.Property2)
            //             .ThenByDescending(item => item.Property3)
            //             .Select((item, index) => new
            //             {
            //                 Item = item,
            //                 RankInGroup = index
            //             })).ToList();
            //            Get the ranking of groups(also known in Oracle as dense_rank)
            //var rankOfBelongingGroup = collection.GroupBy(item => item.Property1)
            // .OrderBy(group => group.Key)
            // .Select((group, index) => new
            // {
            //     Items = group,
            //     Rank = index
            // })
            //.SelectMany(v => v.Items, (s, i) => new
            //{
            //    Item = i,
            //    DenseRank = s.Rank
            //}).ToList();
            List<SomeObject> collection = new List<SomeObject>
                {
                 new SomeObject { Property1 = 1, Property2 = 1, Property3 = 1},
                 new SomeObject { Property1 = 1, Property2 = 2, Property3 = 1},
                 new SomeObject { Property1 = 1, Property2 = 2, Property3 = 2},
                 new SomeObject { Property1 = 2, Property2 = 1, Property3 = 1},
                 new SomeObject { Property1 = 2, Property2 = 2, Property3 = 1},
                 new SomeObject { Property1 = 2, Property2 = 2, Property3 = 1},
                 new SomeObject { Property1 = 2, Property2 = 3, Property3 = 1}
               };
        }
    }

    public class SomeObject
    {
        public int Property1 { get; set; }
        public int Property2 { get; set; }
        public int Property3 { get; set; }
        public override string ToString()
        {
            return string.Join(", ", Property1, Property2, Property3);
        }
    }


}
