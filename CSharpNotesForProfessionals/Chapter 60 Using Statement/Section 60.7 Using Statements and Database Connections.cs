using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_60_Using_Statement_Section_60_7
{
    internal class AppConnection
    {
        public AppConnection()
        {

            using (var connection = new SqlConnection(""))
            {
                var query = "select * from A ";

                using (var commend = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = commend.ExecuteReader())
                    {
                        // 
                    }
                }
            }


            using (var connection = new SqlConnection(""))
            {
                var query = "";
                using (var commend = new SqlCommand(query, connection))
                {
                    connection.Open();
                    commend.ExecuteNonQuery();
                }
            }

            using (var context = new YourDbContext())
            {

            }
        }



    }

    public class YourDbContext : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
