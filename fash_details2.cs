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
    public partial class fash_details2 : Form
    {
        public fash_details2()
        {
            InitializeComponent();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            fashionCat facat2 = new fashionCat();
            facat2.Show();
        }

        private void fash_details2_Load(object sender, EventArgs e)
        {

        }
    }
}
