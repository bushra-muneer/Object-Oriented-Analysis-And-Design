using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.DbServices;

namespace FoodOrdering_ooad_.Entitty
{
    class viewreceipt
    {

        public int orderid;
        public int cutomerid;
        public string CustomerName;

        public string Itemname;
        public int price;
        public int Itemtotall;
        public int quantity;

        public string date;
        public string status;





        DBOrder orders = new DBOrder();
        public List<DBOrder> GetOrderdetail(int id)
        {

            return  orders.Orderdetail(id);
        
       
        }


        public List<DBOrder> GetBilldetail(int id)
        {

            return orders.Billdetail(id);

           
        }




        // admin k lea
        public List<DBOrder> GetBilldetail()
        {

            return orders.Billdetail();


        }


    }
}
