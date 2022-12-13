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
    public partial class prod_details1 : Form
    {
        public prod_details1()
        {
            InitializeComponent();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            products prod = new products();
            prod.Show();
        }

        private void prod_details1_Load(object sender, EventArgs e)
        {

        }
    }
}
