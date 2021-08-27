using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_.Controller
{
    class cancelorderController
    {
        cancelorder cancelodr = new cancelorder();
      
        
        public void CancelOrder(string date,int userid,string username,int orderid,int totall,string status)
        {
            cancelodr.CancelOrder(date,userid,username,orderid,totall,status);
        
        }







        viewreceipt view = new viewreceipt();
        public void GetBilldetail(ListView lst)
        {
            lst.Items.Clear();
            foreach (var item in view.GetBilldetail())
            {


                ListViewItem list = new ListViewItem();
                list.SubItems.Add(item.date);
                list.SubItems.Add((item.customerid).ToString());
                list.SubItems.Add((item.CustomerName).ToString());
                list.SubItems.Add((item.orderid).ToString());
                list.SubItems.Add((item.Itemtotall).ToString());
                list.SubItems.Add(item.status);

                lst.Items.Add(list);

            }





        }






    }
}
