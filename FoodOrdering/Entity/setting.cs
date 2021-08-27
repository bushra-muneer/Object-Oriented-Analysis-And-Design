using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering_ooad_.Entitty
{
    class setting
    {
        public static int OrdderId;
        public void AddCustomerrid(int id)
        {

            string query = "insert into BridgeTable Values(" + id + ")";
            SqlCommand sc = new SqlCommand(query, Connection.get());
            sc.ExecuteNonQuery();

        }





        public void getorderid()
        {

            string q = "select MAX(OrderId) From BridgeTable";

            SqlCommand sc = new SqlCommand(q, Connection.get());

            SqlDataReader sd = sc.ExecuteReader();


            while (sd.Read())
            {
                OrdderId = (int)sd[0];
            }

            sd.Close();
        }


    }
}
