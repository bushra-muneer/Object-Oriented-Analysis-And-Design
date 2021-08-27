using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering_ooad_.Entitty
{
    class placeorder
    {

        public string ItemName;
        public int Price;
        public int Quantity;
        public int ItemTotall;

        public static int OverAllTOtall;


        public void AddItem(placeorder place)
        {

            int orderid = setting.OrdderId;

            string query = "insert into [Order_] Values(" +orderid+ ",'"+place.ItemName+"',"+place.Price+","+place.Quantity+","+place.ItemTotall+")";
            SqlCommand sc = new SqlCommand(query, Connection.get());
            sc.ExecuteNonQuery();
              
        }

        public List<placeorder> GetorderDetail()
        {
            int id = setting.OrdderId;

            String q = "select ItemName ,Rs,Quantity,ItemTotall from [Order_] Where OrderId=" + id;

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            List<placeorder> lst = new List<placeorder>();
            while (sd.Read())
            {
                placeorder place = new placeorder();
                place.ItemName = (string)sd[0];
                place.Price = (int)sd[1];
                place.Quantity = (int)sd[2];
                place.ItemTotall = (int)sd[3];

                lst.Add(place);
              


            }
            sd.Close();

            return lst;

           
        }













    }
}
