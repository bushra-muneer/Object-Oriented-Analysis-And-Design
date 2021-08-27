using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering_ooad_.Entitty
{
    class login
    {

     //   public  int Cutromerid;
        public  string name;
        public string password;
        public string email;
        public string contact;

        public string type;

        public static int customerid;
        public static string customername;
        public static string customertype;

        //public static bool checker;

        public bool Verify(string emaill)
        {

            string q = "select UserName from Users where Email='"+emaill+"'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            while (sd.Read())
            {

                name=(string)sd[0];


            }
            sd.Close();

            if (name==null)
            {

                return true;
            }
            else
            {
                return false;
            }

        }


        public bool Verify(string namee,string password,string emaill)
        {
            string q = "select UserId ,UserName , Type from Users where Email='"+ emaill+"' AND Password='"+password+"' AND UserNAme='"+namee+"'";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            SqlDataReader sd = sc.ExecuteReader();

            while (sd.Read())
            {
                login.customerid = (int)sd[0];
               login.customername = (string)sd[1];
                login.customertype = (string)sd[2];
               

            }
            sd.Close();

            if (login.customername == null)
            {
                return false;

            }
            else
            {
                return true;

             }
       
        
        }










        public void Regester(login log)
        {

            string q = "insert into Users values('" + log.name + "','" + log.contact + "','" + log.email + "','" + log.password + "','"+log.type+"')";
            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }


    }
}
