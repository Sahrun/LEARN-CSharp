using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_26_Collection_Initializers
{
    public class LotteryTicket : IEnumerable
    {
        public int[] LuckyNumbers;
        public string UserName;
        public void Add(string userName, params int[] luckyNumbers)
        {
            UserName = userName;
            LuckyNumbers = luckyNumbers;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}

