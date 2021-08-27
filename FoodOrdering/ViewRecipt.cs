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

namespace FoodOrdering_ooad_
{
    public partial class ViewRecipt : Form
    {
        public ViewRecipt()
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

                MessageBox.Show("Enter Odder Id");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                listView2.Items.Clear();
                controller.GetBilldetail(textBox2,listView2);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new ViewCustomer().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new ManageItem().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Admin_CancelOrder().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new ViewRecipt().Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        cancelorderController cont = new cancelorderController();
        private void ViewRecipt_Load(object sender, EventArgs e)
        {
            cont.GetBilldetail(listView2);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            cont.GetBilldetail(listView2);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new ViewFeedback().Show();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
