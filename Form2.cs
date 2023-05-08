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

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public string conString = "Data Source=DESKTOP-GOK35G8;Initial Catalog=Pizzeria;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT username, passkey FROM Users WHERE username = '"+textBox1.Text+"' AND passkey = '"+textBox2.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login u krye me sukses!");
                this.Hide();

                Form1 form = new Form1(textBox1.Text);
                form.ShowDialog();


            }
            else
            {
                MessageBox.Show("Login gabim!");
            }
            con.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new Form3();
            login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
