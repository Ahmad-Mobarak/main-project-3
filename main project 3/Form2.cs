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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ahmad_bqh2ijo\source\repos\main project 3\main project 3\Database1.mdf"";Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Int32.Parse(textBox1.Text.ToString());
            int phone = Int32.Parse(textBox5.Text.ToString());
            string name = textBox3.Text.ToString();
            string password = textBox2.Text.ToString();
            int age = Int32.Parse(textBox6.Text.ToString());
            string state = textBox4.Text.ToString();
            SqlCommand sq = new SqlCommand("update loginu set password = '" + password + "', name = '" + name + "',state ='" + state + "',age =" + age + ",phone =" + phone + " where id ="+id+"", conn);
            sq.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Int32.Parse(textBox1.Text.ToString());
            int phone = Int32.Parse(textBox5.Text.ToString());
            string name = textBox3.Text.ToString();
            string password = textBox2.Text.ToString();
            int age = Int32.Parse(textBox6.Text.ToString());
            string state = textBox4.Text.ToString();
            SqlCommand sq = new SqlCommand("insert into loginstd values(" + id + ",'" + password + "','" + name + "','" + state + "','" + age + "'," + phone + ")", conn);
            sq.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id, name, state from loginu", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
