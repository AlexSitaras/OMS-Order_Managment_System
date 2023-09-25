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
    public partial class mainmenuform : Form
    {
        public mainmenuform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcust addcust = new addcust();
            addcust.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addordform addorder1 = new addordform();
            addorder1.Show();
        }

        private void mainmenuform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchordform seordf = new searchordform();
            seordf.Show();
        }
    }
}
