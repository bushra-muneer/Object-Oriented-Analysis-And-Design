using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Entitty;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace FoodOrdering_ooad_.DbServices
{
    class DBManue
    {


        public void InertItem(byte[] image,string category,string name,int price)
        {

            string query = "Insert into [Manue] Values('"+category+"','"+name+"',"+price+",@image)";
            SqlCommand sc = new SqlCommand(query, Connection.get());
            sc.Parameters.Add(new SqlParameter("@image", image));
            sc.ExecuteNonQuery();


        }




        public void DeleteItem(int id)
        { 
        string q="Delete  [Manue] where ManueId="+id;
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }






        public void ShowItem(ListView lst)
        {

            String q = "Select  [ManueId], [ManueCategory],[ManueName] ,[Price] From [Manue]";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();


            while (sd.Read())
            {
                

                ListViewItem list = new ListViewItem();
                list.SubItems.Add(((int)sd[0]).ToString());
                list.SubItems.Add((string)sd[1]);
                list.SubItems.Add((string)sd[2]);
                list.SubItems.Add(((int)sd[3]).ToString());

                lst.Items.Add(list);


            }
            sd.Close();

        }





        public void SearchItem(string cate,ListView lst)
        {
            String q = "Select  [ManueId],[ManueCategory],[ManueName],Price From [Manue] where [ManueCategory]='"+cate+"'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();


            while (sd.Read())
            {


                ListViewItem list = new ListViewItem();
                list.SubItems.Add(((int)sd[0]).ToString());
                list.SubItems.Add((string)sd[1]);
                list.SubItems.Add((string)sd[2]);
                list.SubItems.Add(((int)sd[3]).ToString());

                lst.Items.Add(list);


            }   
            sd.Close();


        }




        static byte[] img;
        public void GetUpdate(int id,ComboBox cat,TextBox name,TextBoxBase price,PictureBox pic)
        {

            string q = "Select ManueCategory, ManueName, Price ,Image from Manue where ManueId=" + id;


            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            while (sd.Read())
            {

                cat.Text = (string)sd[0];
                name.Text = (string)sd[1];
                price.Text = ((int)sd[2]).ToString();


                 img = (byte[])(sd[3]);                // yaha imgae ho ge set
                MemoryStream ms = new MemoryStream(img);
                pic.Image = Image.FromStream(ms);
            }
            sd.Close();
        }




        public void Update(byte[] image, ComboBox category, TextBox name, TextBox price,int id)
        {

            string query = "Update  Manue  Set ManueCategory='" + category.Text + "',ManueName='" + name.Text + "',Price='" +int.Parse( price.Text) + "',Image=@image where ManueId=" + id;
            SqlCommand sc = new SqlCommand(query, Connection.get());
            sc.Parameters.Add(new SqlParameter("@image",image));
            sc.ExecuteNonQuery();


        }



        public void Update(ComboBox category, TextBox name, TextBox price, int id)
        {
          //  int pricee = int.Parse(price.Text);
            string query = "Update [Manue]  Set ManueCategory='" + category.Text + "',ManueName='" + name.Text + "',Price=" + int.Parse(price.Text) + ",Image=@img where ManueId=" + id ;
            SqlCommand sc = new SqlCommand(query, Connection.get());
            sc.Parameters.Add(new SqlParameter("@img", img));
            sc.ExecuteNonQuery();


        }






        // ya yaah say place order ka kam hay



            /// <summary>
            /// /////////////////////// list of all manue item in category//////////
            /// </summary>
            /// <returns></returns>

        public List<string> Burger()
        {

            string q = "select ManueName from Manue where  ManueCategory='BURGER'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }



        public List<string> Traditional()
        {

            string q = "select ManueName from Manue where  ManueCategory='TRADITIONAL'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }


        public List<string> ChikenMeal()
        {

            string q = "select ManueName from Manue where  ManueCategory='CHICKENMEAL'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }

        public List<string> Pizza()
        {

            string q = "select ManueName from Manue where  ManueCategory='PIZZA'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }


        public List<string> Snacke()
        {

            string q = "select ManueName from Manue where  ManueCategory='SNACKS'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }


        public List<string> IceCream()
        {

            string q = "select ManueName from Manue where  ManueCategory='ICECREAM'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }

        public List<string> Desserts()
        {

            string q = "select ManueName from Manue where  ManueCategory='DESSERT'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }

        public List<string> Drink()
        {

            string q = "select ManueName from Manue where  ManueCategory='DRINK'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<string> lst = new List<string>();
            while (sd.Read())
            {

                lst.Add((string)sd[0]);

            }

            sd.Close();
            return lst;
        }






        // yaha jab wo addd kr raha ho to pic yaha say show ho ge say


        // bhand yah hay k ager 2same name walay item aajae to
        public void GetItem(ComboBox itemname, Label price, PictureBox pic)
        {
            string q = "select  Price ,Image from Manue where ManueName='" + itemname.Text + "'";


            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            while (sd.Read())
            {
                price.Text = ((int)sd[0]).ToString();

                img = (byte[])(sd[1]);                // yaha imgae ho ge set
                MemoryStream ms = new MemoryStream(img);
                pic.Image = Image.FromStream(ms);

            }

            sd.Close();








        }
    }
}
