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
    public partial class prod_details6 : Form
    {
        public prod_details6()
        {
            InitializeComponent();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            products prod = new products();
            prod.Show();
        }

        private void prod_details6_Load(object sender, EventArgs e)
        {

        }
    }
}
