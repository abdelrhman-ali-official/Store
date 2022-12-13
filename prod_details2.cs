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
    public partial class prod_details2 : Form
    {
        public prod_details2()
        {
            InitializeComponent();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            products pro1 = new products();
            pro1.Show();
        }

        private void prod_details2_Load(object sender, EventArgs e)
        {

        }

        private void picBoxBack_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            products prod = new products();
            prod.Show();
        }
    }
}
