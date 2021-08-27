using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_.DbServices
{
    class DBOrder
    {

        public string Itemname;
        public int price;
        public int quantity;
        public int Itemtotall;

        public string CustomerName;
        public string date;
        public string status;
        public int orderid;
        public int customerid;


        public List<DBOrder> Orderdetail(int id)
        {

            string q = " select ItemName , Rs , Quantity ,ItemTotall from [Order_] where OrderId=" + id;
           
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            List<DBOrder> lst = new List<DBOrder>();

            while (sd.Read())
            {
                DBOrder o = new DBOrder();
                o.Itemname = (string)sd[0];
                o.price = (int)sd[1];
                o.quantity = (int)sd[2];
                o.Itemtotall = (int)sd[3];

                lst.Add(o);
            }

            sd.Close();
            return lst;
            
        }






        public List<DBOrder> Billdetail(int id)
        {

            string q = "select Date  ,UserId ,UserName,OrderId ,Totall ,Status from OrderMaster  where UserId=" + id;

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            List<DBOrder> lst = new List<DBOrder>();

            while (sd.Read())
            {
                DBOrder o = new DBOrder();
                o.date = (string)sd[0];
                o.customerid = (int)sd[1];
                o.CustomerName = (string)sd[2];
                o.orderid = (int)sd[3];
                o.Itemtotall = (int)sd[4];
                o.status = (string)sd[5];

                lst.Add(o);
            }

            sd.Close();
            return lst;

        }




        //admin k lea

        public List<DBOrder> Billdetail()
        {

            string q = "select Date  ,UserId ,UserName,OrderId ,Totall ,Status from OrderMaster";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            List<DBOrder> lst = new List<DBOrder>();

            while (sd.Read())
            {
                DBOrder o = new DBOrder();
                o.date = (string)sd[0];
                o.customerid = (int)sd[1];
                o.CustomerName = (string)sd[2];
                o.orderid = (int)sd[3];
                o.Itemtotall = (int)sd[4];
                o.status = (string)sd[5];

                lst.Add(o);
            }

            sd.Close();
            return lst;

        }









    }
}
