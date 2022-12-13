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
    public partial class fash_details1 : Form
    {
        public fash_details1()
        {
            InitializeComponent();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            fashionCat facat1 = new fashionCat();
            facat1.Show();
        }
    }
}
