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
    public partial class Regester : Form
    {
        public Regester()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        loginController controller = new loginController();
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox3.Text.Contains("@") && textBox3.Text.Contains("."))
            {
                controller.Regesteration(textBox1, textBox2, textBox3, textBox4, comboBox1);
            }
            else
            {
                MessageBox.Show("Enter Valid Email Format");
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

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        public Regester Regester1
        {
            get => default;
            set
            {
            }
        }
    }
}
