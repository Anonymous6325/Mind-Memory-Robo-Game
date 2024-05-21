using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_103_ROSAL___MAKASAYAN
{
    public partial class Sub_Menu : Form
    {
        public Sub_Menu()
        {
            InitializeComponent();
        }

        private void Sub_Menu_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load_1(object sender, EventArgs e)
        {// Create an instance of Form1
            Mind_Testcs game1 = new Mind_Testcs();

            // Show Form1 and hide the Menu form
            game1.Show();
            this.Hide();

        }
    }
}
