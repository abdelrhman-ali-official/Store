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
    public partial class groc_details2 : Form
    {
        public groc_details2()
        {
            InitializeComponent();
        }

        private void AddToCart1_Click(object sender, EventArgs e)
        {

        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grocary groc = new Grocary();
            groc.Show();
        }
    }
}
