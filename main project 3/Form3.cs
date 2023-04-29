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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace main_project_3
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ahmad_bqh2ijo\source\repos\main project 3\main project 3\Database1.mdf"";Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) 
        {
            conn.Open();
            int id = Int32.Parse(textBox1.Text.ToString());
            int phone = Int32.Parse(textBox5.Text.ToString());
            string name = textBox3.Text.ToString();
            string password = textBox2.Text.ToString();
            int age = Int32.Parse(textBox6.Text.ToString());
            string state = "null";
            SqlCommand sq = new SqlCommand("insert into loginu values(" + id + ",'" + password + "','" + name + "','" + state + "','" + age + "'," + phone + ")", conn);
            sq.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
