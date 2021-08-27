using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Controller;
using System.Windows.Forms;
using FoodOrdering_ooad_.Entitty;

namespace FoodOrdering_ooad_
{
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        placeorderController controller = new placeorderController();


        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        setting s = new setting();
        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Hide();

            controller.BurgetList(comboBox1);

            controller.TraditionaList(comboBox2);
            controller.ChickenMealList(comboBox3);

            controller.PizzaList(comboBox4);
            controller.SnacksList(comboBox5);
            controller.ICecreamList(comboBox6);
            controller.DesssertList(comboBox7);
            controller.DrinkList(comboBox8);

            s.getorderid();





        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel7.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            controller.AddStuf(comboBox1, label8, numericUpDown1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox2, label10, numericUpDown2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox3, label11, numericUpDown3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox4, label12, numericUpDown4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox5, label13, numericUpDown5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox6, label14, numericUpDown6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox7, label15, numericUpDown7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            controller.AddStuf(comboBox8, label16, numericUpDown8);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox1,label8,pictureBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox2, label10, pictureBox2);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox3, label11, pictureBox3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox4, label12, pictureBox6);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox5, label13, pictureBox7);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox6, label14, pictureBox8);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox7, label15, pictureBox9);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.GetITem(comboBox8, label16, pictureBox10);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new VIewOrder().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new PlaceOrder().Show();
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

        private void label24_Click(object sender, EventArgs e)
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
    }
}
