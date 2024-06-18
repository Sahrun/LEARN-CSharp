using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12.Section_12._9_ToString__
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override  string ToString()
        {
            return string.Format("Id: {0}, Name: {1}", Id, Name);
        }
    }
}
