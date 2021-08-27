using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FoodOrdering_ooad_.Entitty
{
    class vieworder
    {
        // placeorder p = new placeorder();
        placeorder place = new placeorder();
        public  List <placeorder> OrderDetail()
        {

            return place.GetorderDetail();
        } 
        public void Removeitem(string name)
        {
            int orderid = setting.OrdderId;
        
            string q="Delete [Order_] where OrderId="+orderid+" AND ItemName='"+name+"'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }

        public void Alteritem(TextBox itemname,TextBox price, TextBox quantity)
        {

            int totall = int.Parse(price.Text) * int.Parse(quantity.Text);
            int orderid = setting.OrdderId;


            Removeitem((itemname.Text).ToString());

            string q = "insert into [Order_] Values(" + orderid + ",'" + itemname.Text + "'," + int.Parse (price.Text) + "," + int.Parse(quantity.Text)+ "," +totall+ ")";
           
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();
        }

    }
}
