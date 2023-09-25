using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMANSYS
{
    public partial class addordform : Form
    {
        public addordform()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\customers.mdf;Integrated Security=True");

        OpenFileDialog ordofd = new OpenFileDialog();
        OpenFileDialog sxedofd = new OpenFileDialog();
        OpenFileDialog photofd = new OpenFileDialog();
        OpenFileDialog timolofd = new OpenFileDialog();



        private void addordform_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0 && dateTimePicker1.Text.Length == 0 && orderTextBox.Text.Length == 0 && sxedioTextBox.Text.Length == 0 && photoTextBox.Text.Length == 0 && timolTextBox.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε τα πεδία");
            }
            else if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα όνομα");
            }
            else if (dateTimePicker1.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε μία ημερομηνία");
            }
            else if (orderTextBox.Text.Length == 0 && sxedioTextBox.Text.Length == 0 && photoTextBox.Text.Length == 0 && timolTextBox.Text.Length == 0)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε τα πεδία των αρχείων");
            }
            else
            {


                SqlCommand command = new SqlCommand("SELECT Id FROM cust_info WHERE name = N'" + comboBox1.Text + "' ", cn);

                cn.Open();
                int custid = Convert.ToInt32(command.ExecuteScalar());

                cn.Close();

                //take filenames from paths
                string ordfile = Path.GetFileName(orderTextBox.Text);
                string sxediofile = Path.GetFileName(sxedioTextBox.Text);
                string photofile = Path.GetFileName(photoTextBox.Text);
                string timolfile = Path.GetFileName(timolTextBox.Text);



                if (custid == 0)
                {
                    cn.Open();
                    SqlCommand sm = cn.CreateCommand();
                    sm.CommandType = CommandType.Text;
                    MessageBox.Show("Παρακαλώ επιλέξτε ένα έγκυρο όνομα");
                    cn.Close();

                }
                else
                {
                    cn.Open();
                    SqlCommand sm = cn.CreateCommand();
                    sm.CommandType = CommandType.Text;
                    sm.CommandText = "insert into orders values(N'" + dateTimePicker1.Text + "',N'" + ordfile.ToString() + "',N'" + sxediofile.ToString() + "',N'" + photofile.ToString() + "',N'" + timolfile.ToString() + "',N'" + paytextBox.Text + "',N'" + custid.ToString() + "')";
                    sm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Αποθηκεύτηκε με επιτυχία");

                    addordform orders1 = new addordform();
                    orders1.Show();
                    this.Close();
                }
            }


        }

        private void orderTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            orderTextBox.Text = FileList[0];
        }

        private void orderTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void sxedioTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList1 = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            sxedioTextBox.Text = FileList1[0];
        }

        private void sxedioTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void photoTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList2 = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            photoTextBox.Text = FileList2[0];
        }

        private void photoTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void timolTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList3 = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            timolTextBox.Text = FileList3[0];
        }

        private void timolTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ordbt_Click(object sender, EventArgs e)
        {
            if (ordofd.ShowDialog() == DialogResult.OK)
            {
                orderTextBox.Text = ordofd.SafeFileName;
            }
        }

        private void sxedbt_Click(object sender, EventArgs e)
        {
            if (sxedofd.ShowDialog() == DialogResult.OK)
            {
                sxedioTextBox.Text = sxedofd.SafeFileName;
            }
        }

        private void photobt_Click(object sender, EventArgs e)
        {
            if (photofd.ShowDialog() == DialogResult.OK)
            {
                photoTextBox.Text = photofd.SafeFileName;
            }
        }

        private void timolbt_Click(object sender, EventArgs e)
        {
            if (timolofd.ShowDialog() == DialogResult.OK)
            {
                timolTextBox.Text = timolofd.SafeFileName;
            }
        }
    }
}
