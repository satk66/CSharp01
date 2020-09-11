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

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon =new SqlConnection( @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\LoginApp\LoginApp\LogingDB.mdf;Integrated Security=True");
            string query = "SELECT * FROM Login WHERE Username ='" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim()+"'";
            SqlDataAdapter sba = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            if(dtbl.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();

            }
            else
            {
                MessageBox.Show("아이디나 비번을 확인해 주시길 바랍니다");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
