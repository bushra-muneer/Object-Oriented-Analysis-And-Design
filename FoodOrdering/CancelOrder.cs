using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Entitty;
using System.Windows.Forms;
using FoodOrdering_ooad_.Controller;

namespace FoodOrdering_ooad_
{
    public partial class CancelOrder : Form
    {
        public CancelOrder()
        {
            InitializeComponent();
        }
        
        private void CancelOrder_Load(object sender, EventArgs e)
        {
            label9.Text = login.customername;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new PlaceOrder().Show();
            this.Hide();

        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            new VIewOrder().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new CancelOrder().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new PayBill().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new VIewRecipt_c().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new GIvfFeedback().Show();
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        viewreciptController controller = new viewreciptController();
        private void button3_Click(object sender, EventArgs e)
        {
            controller.GetBilldetail(listView1);
        }
        cancelorderController cancellcontroller = new cancelorderController();
        private void button1_Click(object sender, EventArgs e)
        {

             string date= listView1.SelectedItems[0].SubItems[1].Text;
            DateTime dt = DateTime.UtcNow.Date;

            string currentdate = dt.ToString("dd.MM.yyyy");


            if (string.Equals(currentdate, date))
            {

                string datee = listView1.SelectedItems[0].SubItems[1].Text;
             
                int userid = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);

                string username = listView1.SelectedItems[0].SubItems[3].Text;

                int billid=int.Parse(listView1.SelectedItems[0].SubItems[4].Text);

                int totall = int.Parse(listView1.SelectedItems[0].SubItems[5].Text);

                string status = "Cancel";

                cancellcontroller.CancelOrder(date, userid, username, billid, totall, status);

                controller.GetBilldetail(listView1);
            }
            else
            {
                MessageBox.Show("Order  Out Of date");
            
            }


        }
    }
}
