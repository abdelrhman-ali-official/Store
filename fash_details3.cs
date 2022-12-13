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
    public partial class fash_details3 : Form
    {
        public fash_details3()
        {
            InitializeComponent();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            fashionCat fashion = new fashionCat();
            fashion.Show();
        }

      
    }
}
