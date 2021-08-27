using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.DbServices;
using System.Windows.Forms;

namespace FoodOrdering_ooad_.Controller
{
    class viewcutomerController
    {
        DBCustomer db = new DBCustomer();
        public void ViewCustomer(ListView lst)
        {
           

            var customers = db.ViewCustomer();

            foreach (var item in customers)
            {
                ListViewItem list = new ListViewItem();

                list.SubItems.Add((item.CustomerId.ToString()).ToString());
                list.SubItems.Add(item.Customername);
                list.SubItems.Add((item.Contact.ToString()).ToString());
                list.SubItems.Add(item.Email);
                
                lst.Items.Add(list);


            }
        
        }


        public void searchcustomer(int id,ListView lst)
        {
           
            var item = db.SearchCustomer(id);

            ListViewItem list = new ListViewItem();
            list.SubItems.Add(item.CustomerId.ToString());
            list.SubItems.Add(item.Customername);
            list.SubItems.Add(item.Contact.ToString());
            list.SubItems.Add(item.Email);

            lst.Items.Add(list);

        }


    }
}
