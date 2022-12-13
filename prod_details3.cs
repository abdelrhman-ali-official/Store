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
    public partial class prod_details3 : Form
    {
        public prod_details3()
        {
            InitializeComponent();
        }

        private void prod_details3_Load(object sender, EventArgs e)
        {

        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            products prod = new products();
            prod.Show();
        }
    }
}
