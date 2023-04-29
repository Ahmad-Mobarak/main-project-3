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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ahmad_bqh2ijo\source\repos\main project 3\main project 3\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT count(*) FROM login WHERE id = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataAdapter dau = new SqlDataAdapter("SELECT count(*) FROM loginu WHERE id = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'", conn);
            DataTable dtu = new DataTable();
            dau.Fill(dtu);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            else if (dtu.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form4 ss = new Form4();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Check ID and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("do want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
