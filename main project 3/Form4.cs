using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_project_3
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ahmad_bqh2ijo\source\repos\main project 3\main project 3\Database1.mdf"";Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dau = new SqlDataAdapter("SELECT count(*) FROM loginu WHERE id = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'", conn);
            DataTable dtu = new DataTable();
            dau.Fill(dtu);
            if (dtu.Rows[0][0].ToString() == "1")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from loginu where id =" + textBox1.Text + " ", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    textBox2.Text = rdr.GetValue(1).ToString();
                    textBox3.Text = rdr.GetValue(2).ToString();
                    textBox4.Text = rdr.GetValue(3).ToString();
                    textBox6.Text = rdr.GetValue(4).ToString();
                    textBox5.Text = rdr.GetValue(5).ToString();
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Check ID and password");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
