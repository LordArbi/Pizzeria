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
    public partial class Form3 : Form
    {
        public string conString = "Data Source=DESKTOP-GOK35G8;Initial Catalog=Pizzeria;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "INSERT INTO Users (username, passkey, email)VALUES('" + username.Text + "', '" + password.Text + "', '" + email.Text + "') ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Perdoruesi u rregjistrrua me sukses!");
            this.Close();   
        }
    }
}
