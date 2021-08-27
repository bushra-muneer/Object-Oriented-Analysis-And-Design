using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.Controller;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_
{
    public partial class PayBill : Form
    {
        public PayBill()
        {
            InitializeComponent();
        }
        paybillController controller = new paybillController();
        private void PayBill_Load(object sender, EventArgs e)
        {
            
            controller.OrderDetail(listView1);
            label11.Text = placeorder.OverAllTOtall.ToString();
            label9.Text = login.customername;

            viewrecipt.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            viewrecipt.Show();
            label18.Text = login.customerid.ToString();
            label19.Text = login.customername;
            label20.Text = setting.OrdderId.ToString();
            label21.Text = placeorder.OverAllTOtall.ToString();


            DateTime date = DateTime.UtcNow.Date;
            label22.Text = date.ToString("dd.MM.yyyy");
                


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.Payment(label18,label19,label20,label21,label22);
            this.Hide();
            new Form1().Show();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
