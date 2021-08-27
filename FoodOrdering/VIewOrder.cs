using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FoodOrdering_ooad_.Controller;
using FoodOrdering_ooad_.Entitty;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace FoodOrdering_ooad_
{
    public partial class VIewOrder : Form
    {
        public VIewOrder()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new PlaceOrder().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new PayBill().Show();
            this.Hide();
        }
        vieworderController controller = new vieworderController();
        private void VIewOrder_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            controller.GetDetail(listView1);
            label13.Text = placeorder.OverAllTOtall.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[1].Text;

            if (name!="")
            {



                controller.RemoveItem(name);

                listView1.Items.Clear();
                controller.GetDetail(listView1);
                label13.Text = placeorder.OverAllTOtall.ToString();
            }
            else
            {

                MessageBox.Show("Seelct the order");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].SubItems[1].Text != "")
            {


                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            else
            {

                MessageBox.Show("Select the Order");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            controller.AlterItem(textBox1,textBox2,textBox3);

            controller.GetDetail(listView1);
            textBox1.Text = "ItemName";
            textBox2.Text = "Rs.";
            textBox3.Text = "Quantity";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            controller.GetDetail(listView1);
            label13.Text = placeorder.OverAllTOtall.ToString();
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
           new  Form1().Show();
            this.Hide();
        }
    }
}
