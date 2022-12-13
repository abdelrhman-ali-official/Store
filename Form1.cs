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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool MouseDown = false;
        private Point LastLocation;

       

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
            panel4.Cursor = Cursors.Hand;

        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            panel4.Cursor = Cursors.Default;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                int Newx = (this.Location.X - LastLocation.X) + e.X;
                int Newy = (this.Location.Y - LastLocation.Y) + e.Y;
                this.Location = new Point(Newx, Newy);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            //txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
