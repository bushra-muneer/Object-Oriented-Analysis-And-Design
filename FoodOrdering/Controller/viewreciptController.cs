using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_.Controller
{
    class viewreciptController
    {
        viewreceipt view = new viewreceipt();
        public void GetOrderdetail(TextBox id, ListView lst)
        {

            foreach (var item in view.GetOrderdetail(int.Parse(id.Text)))
            {


                ListViewItem list = new ListViewItem();
                list.SubItems.Add(item.Itemname);
                list.SubItems.Add((item.price).ToString());
                list.SubItems.Add((item.quantity).ToString());
                list.SubItems.Add((item.Itemtotall).ToString());

                lst.Items.Add(list);

            }

        }



        public void GetBilldetail(TextBox id, ListView lst)
        {

            foreach (var item in view.GetBilldetail(int.Parse(id.Text)))
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



        public void GetBilldetail(ListView lst)
        {
            lst.Items.Clear();
            foreach (var item in view.GetBilldetail(login.customerid))
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
