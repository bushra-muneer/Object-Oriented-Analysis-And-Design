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
    class DBPayBill 
    {

       private int id;
        private string name;
        private int billid;
       private int totall;
        private string date;
        private string type;
        public void AddPayment(Label id ,Label name,Label billid ,Label totall ,Label date)
        {
            this.id = int.Parse(id.Text);
            this.name = name.Text;
            this.billid = int.Parse(billid.Text);
            this.totall = int.Parse(totall.Text);
            this.date = (date.Text).ToString();



            type = "Payed";

        string q="insert into OrderMaster values("+this.id+",'"+this.name+"',"+this.billid+"," + this.totall+",'"+this.date+"', '"+type+"')";

            SqlCommand sc = new SqlCommand(q, Connection.get());
            sc.ExecuteNonQuery();

        }


    }
}
