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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void catogaryPic1_Click(object sender, EventArgs e)
        {
            this.Hide();
            products prod = new products();
            prod.Show();
        }

        private void catogaryPic2_Click(object sender, EventArgs e)
        {

            this.Hide();
            fashionCat catogary3 = new fashionCat();
            catogary3.Show();
        }

        private void catogaryPic3_Click(object sender, EventArgs e)
        {

        }

        private void catogaryPic3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Grocary gro = new Grocary();
            gro.Show();
        }
    }
}
