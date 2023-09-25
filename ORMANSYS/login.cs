using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMANSYS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            uname.Text = "fabbrica";
            pass.Text = "1234";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uname.Text.Length == 0 && pass.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε username και password");
            }
            else if (uname.Text.Length == 0 && pass.Text.Length != 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το username");
            }
            else if (uname.Text.Length != 0 && pass.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το password");
            }
            else
            {
                if ( uname.Text == "fabbrica" && pass.Text == "1234")
                {
                    this.Hide();
                    mainmenuform menu = new mainmenuform();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Λάθος username ή password");
                }
            }
        }
    }
}
