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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Regester().Show();
        }
        loginController log = new loginController();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains('@')&&textBox3.Text.Contains('.'))
            {

                log.Verification(textBox1, textBox2, textBox3);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Email Format");

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
