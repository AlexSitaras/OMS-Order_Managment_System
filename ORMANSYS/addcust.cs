using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ORMANSYS
{
    public partial class addcust : Form
    {        
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\customers.mdf;Integrated Security=True");

        public addcust()
        {
            InitializeComponent();

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0 && textBox3.Text.Length == 0 && textBox4.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε τα πεδία");
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε ένα όνομα");
            }
            else 
            {
                sc.Open();
                SqlCommand sm = sc.CreateCommand();
                sm.CommandType = CommandType.Text;
                
                sm.CommandText = "insert into cust_info values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "')";
                sm.ExecuteNonQuery();
                sc.Close();

                MessageBox.Show("Αποθηκεύτηκε με επιτυχία");

                addcust addcust = new addcust();
                addcust.Show();
                this.Close();
            }
        }

        private void addcust_Load(object sender, EventArgs e)
        {

        }
    }
}
