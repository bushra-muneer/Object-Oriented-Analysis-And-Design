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
    public partial class VIewRecipt_c : Form
    {
        public VIewRecipt_c()
        {
            InitializeComponent();
        }
        viewreciptController controller = new viewreciptController();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                listView1.Items.Clear();

                controller.GetOrderdetail(textBox4, listView1);

            }
            else
            {

                MessageBox.Show("Emter Bill Id");
            
            }
        }

        private void VIewRecipt_c_Load(object sender, EventArgs e)
        {

            controller.GetBilldetail(listView2);
        }
          






         




        private void label9_Click(object sender, EventArgs e)
        {
            controller.GetBilldetail(listView2);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new PayBill().Show();
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

        private void label8_Click(object sender, EventArgs e)
        {
            new VIewRecipt_c().Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new GIvfFeedback().Show();
        }
    }
}
