using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_26_Collection_Initializers
{
    public class MyCollection : IEnumerable
    {
        private IList list = new ArrayList();

        public void Add(string item) => list.Add(item);

        public void Add(string item, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(item);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
