using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boda
{
    public partial class Grocary : Form
    {
        public Grocary()
        {
            InitializeComponent();
        }

        private void ProductName1_Click(object sender, EventArgs e)
        {

        }

        private void ProductName6_Click(object sender, EventArgs e)
        {

        }

        private void ProdCartPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            products2 groc = new products2();
            groc.Show();
        }

        private void backCatogary1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage catogary3 = new HomePage();
            catogary3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            groc_details1 groc = new groc_details1();
            groc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            groc_details2 groc = new groc_details2();
            groc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            groc_details3 groc = new groc_details3();
            groc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            groc_details4 groc = new groc_details4();
            groc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            groc_details5 groc = new groc_details5();
            groc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            groc_details6 groc = new groc_details6();
            groc.Show();
        }
    }
}
