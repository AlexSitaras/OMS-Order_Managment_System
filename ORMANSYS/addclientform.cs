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
    public partial class addclientform : Form
    {
        public addclientform()
        {
            InitializeComponent();
        }

        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ALEX\source\repos\ORMANSYS\ORMANSYS\customers.mdf;Integrated Security=True");

        private void savebut_Click(object sender, EventArgs e)
        {
            SqlCommand sm = new SqlCommand("insert customer('" +name.Text+"' , '" +phone.Text+"' , '" +address.Text+"' , '" +country.Text+"')", sc);

            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Η καταχώρηση έγινε με επιτυχία");
        
        
        }

    }
}
