using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering_ooad_.Entitty
{
    class cancelorder
    {
        public int orderid;
        public int date;


        public void CancelOrder(string date,int  userid,string username,int  orderid, int totall, string status)
        { 
            string q="update OrderMaster Set Userid="+userid+",UserName='"+username+"',OrderId="+orderid+",Totall="+totall+",Status='"+status+"' where OrderId="+orderid+"";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }







    }
}
