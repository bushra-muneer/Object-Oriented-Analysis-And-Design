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
    public partial class ManageItem : Form
    {
        public ManageItem()
        {
            InitializeComponent();
        }
        manageitemController controller = new manageitemController();
        private void ManageItem_Load(object sender, EventArgs e)
        {

        }
        string imageurl ="";
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog())
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    imageurl = ofd.FileName.ToString();
                    pictureBox1.ImageLocation = imageurl;

                }
            
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null && comboBox1.Text != "" && textBox1.Text != null && textBox2.Text != "")
            {

                if (button5.Text == "Add")
                {


                    controller.InsertItem(imageurl, comboBox1, textBox1, textBox2);
                    MessageBox.Show("Item Add");
                    imageurl = null;
                }

                if (button5.Text=="Update")
                {
                    if (imageurl != "")
                    {


                        controller.Update(imageurl, comboBox1, textBox1, textBox2,Manuidd);

                        button5.Text = "Add";
                    }
                    else 
                    {
                        controller.Update(comboBox1,textBox1,textBox2,Manuidd);
                            button5.Text = "Add";

                    }
                      
                }
                textBox1.Clear();
                textBox2.Clear();
                pictureBox1.Image = null;

            }
            else
            {
                MessageBox.Show("Somthing is Missing");
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.ShowItem(listView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            controller.SearchItem(comboBox2,listView1);
        }
         
        private void button4_Click(object sender, EventArgs e)
        {
           int id = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            if (listView1.SelectedItems[0].SubItems[1].Text!=null)
            {

                controller.DeleteItem(id);

                controller.ShowItem(listView1);
            }
        }
    static    int Manuidd;
        private void button2_Click(object sender, EventArgs e)
        {
            button5.Text = "Update";

            Manuidd = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);   //is ki jagha direct db say lay ao data ko

            if (listView1.SelectedItems[0].SubItems[1].Text!=null)
            {

                controller.GetUpdate(Manuidd, comboBox1, textBox1, textBox2, pictureBox1);
            }

            //comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            //textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            //textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
                
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
