using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Entitty;
using System.Windows.Forms;
using FoodOrdering_ooad_.DbServices;

namespace FoodOrdering_ooad_.Controller
{
    class paybillController
    {
        placeorder place = new placeorder();
        DBPayBill pay = new DBPayBill();
        public void OrderDetail(ListView view)
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








        public void Payment(Label id,Label name,Label billid,Label total,Label date)
        {
            pay.AddPayment(id,name,billid,total,date);
        
        }






    }
}
