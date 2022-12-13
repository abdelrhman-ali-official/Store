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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();

        }

        private void login_Load(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Hide();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {    
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {                                              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage catogary = new HomePage();
            catogary.Show();
        }
    }
}
