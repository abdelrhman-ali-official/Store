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
    public partial class fashionCat : Form
    {
        public fashionCat()
        {
            InitializeComponent();
        }

        private void fashionCat_Load(object sender, EventArgs e)
        {

        }

        private void ProdCartPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            products2 prod4 = new products2();
            prod4.Show();
        }

        private void backCatogary1_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomePage catogary2 = new HomePage();
            catogary2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fash_details1 fashion = new fash_details1();
            fashion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fash_details2 facat2 = new fash_details2();
            facat2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           fash_details3 fashion = new fash_details3();
            fashion.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            fash_details4 fashion = new fash_details4();
            fashion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fash_details5 fashion = new fash_details5();
            fashion.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           fash_details6 fashion = new fash_details6();
            fashion.Show();
        }
    }
}
