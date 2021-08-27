using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FoodOrdering_ooad_.Entitty;
using System.Threading.Tasks;

namespace FoodOrdering_ooad_.Entitty
{
    class paybill
    {



        public string date;

        public string customername;
        public int ID;
        public int totall;
        public int Billid;



        vieworder view = new vieworder();

        public List<placeorder> OrderDetail()
        {
            return view.OrderDetail();

        }


    }
}
