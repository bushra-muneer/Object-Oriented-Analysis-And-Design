using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrdering_ooad_.DbServices;

namespace FoodOrdering_ooad_
{
    public partial class GIvfFeedback : Form
    {
        public GIvfFeedback()
        {
            InitializeComponent();
        }
        DBFeedBack feed = new DBFeedBack();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text!=null)
            {

                feed.AddFeedBack(textBox4);
                textBox4.Clear();
            }
        }
    }
}
