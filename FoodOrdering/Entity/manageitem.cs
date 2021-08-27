using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Controller;
using System.Windows.Forms;
using FoodOrdering_ooad_.DbServices;

namespace FoodOrdering_ooad_.Entitty
{
    class manageitem
    {

        public int ManuId;
             public string ManueCategory;
        public string ManueName;
        public int Price;
        public byte[] pictue;



        DBManue manue = new DBManue();
        public void InserItem(byte[] image, ComboBox category, TextBox name, TextBox price)
        {
            this.ManueCategory = category.Text.ToString();
            this.ManueName = name.Text.ToString();
            this.Price = (int.Parse(price.Text));
            this.pictue = image;

            manue.InertItem(pictue, ManueCategory, ManueName, Price);






        }

    }
}
