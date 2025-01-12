using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_32
    {
        public Section_66_32() {
            var transactions = new List<Transaction>
                {
                 new Transaction { Category = "Saving Account", Amount = 56, Date = DateTime.Today.AddDays(1) },
                 new Transaction { Category = "Saving Account", Amount = 10, Date = DateTime.Today.AddDays(-10)
                },
                 new Transaction { Category = "Credit Card", Amount = 15, Date = DateTime.Today.AddDays(1) },
                 new Transaction { Category = "Credit Card", Amount = 56, Date = DateTime.Today },
                 new Transaction { Category = "Current Account", Amount = 100, Date = DateTime.Today.AddDays(5)
                },
            };

            var summaryApproach1 = transactions.GroupBy(T => T.Category)
                .Select(x =>
                new
                {
                    Category = x.Key,
                    Count = transactions.Count(),
                    Amount = transactions.Sum(a => a.Amount)
                }).ToList();

            Console.WriteLine("-- Summary: Approach 2 --");
            summaryApproach1.ForEach( row => Console.WriteLine($"Category: {row.Category}, Amount: {row.Amount}, Count: {row.Count}"));
        }
    }

    public class Transaction
    {
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }



    
}
