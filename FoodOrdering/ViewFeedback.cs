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
    public partial class ViewFeedback : Form
    {
        public ViewFeedback()
        {
            InitializeComponent();
        }
        DBFeedBack feed = new DBFeedBack();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            feed.GetFeedBack(listView1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
