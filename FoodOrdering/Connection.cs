using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering_ooad_
{
    class Connection
    {
        static SqlConnection sc;
        public static SqlConnection get()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = @"initial catalog=FooddOrdering;integrated security=true;data source=DESKTOP-N4N28D3"; 
                sc.Open();
            }
            return sc;

        }
    }
}
