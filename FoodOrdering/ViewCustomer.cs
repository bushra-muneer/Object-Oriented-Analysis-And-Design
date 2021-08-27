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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }
        viewcutomerController controller = new viewcutomerController();
        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            controller.ViewCustomer(listView1);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            controller.ViewCustomer(listView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {


                listView1.Items.Clear();
                int id = int.Parse(textBox2.Text);
                controller.searchcustomer(id, listView1);

            }
            else
            {

                MessageBox.Show("Enter the Id");
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

        private void label6_Click(object sender, EventArgs e)
        {
            new ViewFeedback().Show();
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
