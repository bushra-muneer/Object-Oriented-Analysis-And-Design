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
    class DBCustomer : viewcustomer
    {

        ////Errorro hay i may
        ///





        //public int CustomerId;
        //public string Customername;
        //public string Email;
        //public string Contact;




        public  List<DBCustomer> ViewCustomer()
        {


            string q = "select UserId ,UserName,Contact,Email from [Users] where Type= 'CUSTOMER'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();
            List<DBCustomer> lst = new List<DBCustomer>();
            while (sd.Read())
            {
                DBCustomer cust = new DBCustomer();

                cust.CustomerId = (int)sd[0];
                cust.Customername = (string)sd[1];
                cust.Contact = (string)sd[2];
                cust.Email = (string)sd[3];


                lst.Add(cust);


            }
          
            sd.Close();
            return lst;

        }

        public DBCustomer SearchCustomer(int id)
        {


            string q = "select   UserId , UserName , Contact , Email   from [Users] where UserId="+ id+ " AND  Type = 'CUSTOMER'";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            DBCustomer db = new DBCustomer();

            while (sd.Read())
            {

                db.CustomerId = (int)sd[0];
                db.Customername = (string)sd[1];
                db.Contact = (string)sd[2];
                db.Email = (string)sd[3];


            }
            sd.Close();
            return db;

        }

    }
}
