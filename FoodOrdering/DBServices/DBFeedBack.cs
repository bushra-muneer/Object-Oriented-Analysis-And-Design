using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_.DbServices
{
    class DBFeedBack
    {

        public void AddFeedBack(TextBox feedback)
        {
            int id = login.customerid;
            string q = "inserts int [FeedBack] values("+id+",'"+feedback.Text+"')";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();


        }




        public void GetFeedBack(ListView lst)
        {
            lst.Items.Clear();

            String q = "Select * from FeedBack";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();


            while (sd.Read())
            {


                ListViewItem list = new ListViewItem();
                list.SubItems.Add(((int)sd[0]).ToString());
                list.SubItems.Add((string)sd[1]);

                lst.Items.Add(list);
            }
            sd.Close();
        }

    }
}
