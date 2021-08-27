using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_.Controller
{
    class vieworderController
    {
        vieworder vieww = new vieworder();
        placeorder place = new placeorder();
        public void GetDetail(ListView view)
        {
            view.Items.Clear();
            placeorder.OverAllTOtall = 0;
            foreach (var item in place.GetorderDetail())
            {
                ListViewItem lstview = new ListViewItem();

                lstview.SubItems.Add(item.ItemName);
                lstview.SubItems.Add(item.Price.ToString());
                lstview.SubItems.Add(item.Quantity.ToString());
                lstview.SubItems.Add(item.ItemTotall.ToString());


                placeorder.OverAllTOtall += item.ItemTotall;

                view.Items.Add(lstview);
            }
           
        }







        public void RemoveItem(string name)
        {

            vieww.Removeitem(name);
        
        }


        public void AlterItem(TextBox itemname, TextBox price, TextBox quantity)
        {
            vieww.Alteritem(itemname, price, quantity);
        
        
        }


    }
}
