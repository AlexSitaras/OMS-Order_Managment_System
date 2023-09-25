using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMANSYS
{
    public partial class searchordform : Form
    {
        public searchordform()
        {
            InitializeComponent();
            
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\customers.mdf;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchordform_Load(object sender, EventArgs e)
        {
            BindData();
            

            
        }

        public void BindData()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from cust_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["name"].ToString());
            }
            cn.Close();



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length != 0)
            {
                comboBox2.Items.Clear();
                cn.Open();
               
                SqlCommand cmd1 = new SqlCommand("SELECT o.date FROM orders o INNER JOIN cust_info c on c.Id = o.cust_id and c.name = N'" + comboBox1.Text + "' ", cn);
                
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                
                da1.Fill(dt1);
              

                foreach (DataRow dr1 in dt1.Rows)
                {
                    comboBox2.Items.Add(dr1["date"].ToString());
                }
                cn.Close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Έγγραφο Παραγγελίας")
            {
                SqlCommand command1 = new SqlCommand("SELECT o.ord FROM orders o INNER JOIN cust_info c on c.Id = o.cust_id and c.name = N'" + comboBox1.Text + "' and o.date = N'"+comboBox2.Text+"' ", cn);

                cn.Open();
                string arxeio = Convert.ToString(command1.ExecuteScalar());
                
                cn.Close();

                Process.Start(@"C:\source\repos\ORMANSYS\ΕΓΓΡΑΦΑ\" + arxeio.ToString());
            }
            if (comboBox3.Text == "Έγγραφο Σχεδίου")
            {
                SqlCommand command1 = new SqlCommand("SELECT o.sxedio FROM orders o INNER JOIN cust_info c on c.Id = o.cust_id and c.name = N'" + comboBox1.Text + "' and o.date = N'" + comboBox2.Text + "' ", cn);

                cn.Open();
                string arxeio = Convert.ToString(command1.ExecuteScalar());

                cn.Close();
                Process.Start(@"C:\source\repos\ORMANSYS\ΕΓΓΡΑΦΑ\" + arxeio.ToString());
            }
            if (comboBox3.Text == "Φωτογραφία Προιόντος")
            {
                SqlCommand command1 = new SqlCommand("SELECT o.photo FROM orders o INNER JOIN cust_info c on c.Id = o.cust_id and c.name = N'" + comboBox1.Text + "' and o.date = N'" + comboBox2.Text + "' ", cn);

                cn.Open();
                string arxeio = Convert.ToString(command1.ExecuteScalar());

                cn.Close();
                Process.Start(@"C:\source\repos\ORMANSYS\ΕΓΓΡΑΦΑ\" + arxeio.ToString());
            }
            if (comboBox3.Text == "Έγγραφο Τιμολογίου")
            {
                SqlCommand command1 = new SqlCommand("SELECT o.timol FROM orders o INNER JOIN cust_info c on c.Id = o.cust_id and c.name = N'" + comboBox1.Text + "' and o.date = N'" + comboBox2.Text + "' ", cn);

                cn.Open();
                string arxeio = Convert.ToString(command1.ExecuteScalar());

                cn.Close();
                Process.Start(@"C:\source\repos\ORMANSYS\ΕΓΓΡΑΦΑ\" + arxeio.ToString());
            }


        }
    }
}
