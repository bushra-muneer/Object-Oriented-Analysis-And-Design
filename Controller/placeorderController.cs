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
    class placeorderController
    {
        placeorder place = new placeorder();


        public void AddStuf(ComboBox itemname,Label price,NumericUpDown quantity)
        {
            if (price.Text!="Rs")
            {


                place.ItemName = itemname.Text.ToString();
                place.Price = int.Parse(price.Text);
                place.Quantity = int.Parse(quantity.Text);

                place.ItemTotall = place.Price * place.Quantity;

                place.AddItem(place);
                price.Text = "Rs";
                quantity.Value = 1;
            }
            else
            {

                MessageBox.Show("select  the manue First");
             
            }
        
        }




        DBManue manue = new DBManue();
        public void BurgetList(ComboBox itemname)
        {


            foreach (var item in manue.Burger())
            {
               itemname.Items.Add(item);
            }

        }




        public void TraditionaList(ComboBox itemname)
        {


            foreach (var item in manue.Traditional())
            {
                itemname.Items.Add(item);
            }

        }



        public void ChickenMealList(ComboBox itemname)
        {


            foreach (var item in manue.ChikenMeal())
            {
                itemname.Items.Add(item);
            }

        }



        public void PizzaList(ComboBox itemname)
        {


            foreach (var item in manue.Pizza())
            {
                itemname.Items.Add(item);
            }

        }


        public void SnacksList(ComboBox itemname)
        {


            foreach (var item in manue.Snacke())
            {
                itemname.Items.Add(item);
            }

        }



        public void ICecreamList(ComboBox itemname)
        {


            foreach (var item in manue.IceCream())
            {
                itemname.Items.Add(item);
            }

        }


        public void   DesssertList(ComboBox itemname)
        {


            foreach (var item in manue.Desserts())
            {
                itemname.Items.Add(item);
            }

        }


        public void DrinkList(ComboBox itemname)
        {


            foreach (var item in manue.Drink())
            {
                itemname.Items.Add(item);
            }

        }





        public void GetITem(ComboBox itemname,Label pric,PictureBox pic)
        {
            if (itemname.Text!="")
            {

                manue.GetItem(itemname, pric, pic);

            }
            else 
            {
                MessageBox.Show("Select the Item First");
            
            }
        
        }









    }


}
