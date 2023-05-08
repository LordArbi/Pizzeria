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

  
    public partial class Form1 : Form
    {
        public string conString = "Data Source=DESKTOP-GOK35G8;Initial Catalog=Pizzeria;Integrated Security=True";
        // Propertie vars
        public string size;
        public string crust;
        public string toppings;
        public string drinks;
        public string[] allDrinks = new string[] {};
        public string drinkQuant;
        public string otherItems;

        List<string>toppingsT = new List<string> ();
        List<string> drinksD = new List<string>();
        List<string>quantityQ = new List<string> ();
        List<string> otherit = new List<string>();

        public string t;
        public string d;
        public string q;
        public string o;

        public string username;

        public Form1(string usr)
        {
            InitializeComponent();
            username = usr;
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pizza Type Selection Fn1353

            if (radioButton1.Checked == true)
            {
                size = radioButton1.Text;   
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("4.00");
                    listView1.Items.Add(item);
                    crust = radioButton5.Text;
         
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("4.00");
                    listView1.Items.Add(item);
                    crust = radioButton6.Text;
               
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("4.00");
                    listView1.Items.Add(item);
                    crust = radioButton7.Text;
             
                }

            }

            else if (radioButton2.Checked == true)
            {
                size = radioButton2.Text;
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);
                    crust = radioButton5.Text;
              
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);
                    crust=radioButton6.Text;    

             
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);
                    crust = radioButton7.Text;
                }
            }

            else if (radioButton3.Checked == true)
            {
                size = radioButton3.Text;
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);
                    crust = radioButton5.Text; 
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);
              crust = radioButton6.Text;
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);
            crust=radioButton7.Text;
                }
            }

            else if (radioButton4.Checked == true)
            {
                size=radioButton4.Text;
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listView1.Items.Add(item);
            crust = radioButton5.Text;
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listView1.Items.Add(item);
               crust = radioButton6.Text;
                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listView1.Items.Add(item);
              crust = radioButton7.Text;
                }
            }


            //Pizza Topping Selection

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox1.Text;
                toppingsT.Add(checkBox1.Text);
            }
            
            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Extra Cheese Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox2.Text;
                toppingsT.Add(checkBox2.Text);
            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Mushroom Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox3.Text;
                toppingsT.Add(checkBox3.Text);
            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ham Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
             toppings = checkBox4.Text;
                toppingsT.Add(checkBox4.Text);
            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bacon Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
            toppings=checkBox5.Text;
                toppingsT.Add(checkBox5.Text);
            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ground Beef Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
          toppings =checkBox6.Text;
                toppingsT.Add(checkBox6.Text);
            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Jalapeno Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
            toppings = checkBox7.Text;
                toppingsT.Add(checkBox7.Text);
            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pineapple Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox8.Text;
                toppingsT.Add(checkBox8.Text);
            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Dried Shrimps Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox9.Text;
                toppingsT.Add(checkBox9.Text);
            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Anchovies Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox10.Text;
                toppingsT.Add(checkBox10.Text);
            }

            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Sun Dried Tomatoes Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox11.Text;
                toppingsT.Add(checkBox11.Text);
            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Spinach Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox12.Text;
                toppingsT.Add(checkBox12.Text);
            }


            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Roasted Garlic Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox13.Text;
                toppingsT.Add(checkBox13.Text);
            }

            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Shredded Chicken Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);
                toppings = checkBox14.Text;
                toppingsT.Add(checkBox14.Text);
            }

            //Drink Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke - Can");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox15.Text;
                drinkQuant = textBox1.Text;
                quantityQ.Add(textBox1.Text);
                drinksD.Add(checkBox15.Text);
            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke - Can");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox16.Text;
                drinkQuant = textBox2.Text;
                allDrinks = new string[] { checkBox16.Text };

                quantityQ.Add(textBox2.Text);
                drinksD.Add(checkBox16.Text);
            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea - Can");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox17.Text;
                drinkQuant = textBox3.Text;
                allDrinks = new string[] { checkBox17.Text };

                quantityQ.Add(textBox3.Text);
                drinksD.Add(checkBox17.Text);
            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ginger Ale - Can");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox18.Text;
                drinkQuant = textBox4.Text;
                allDrinks = new string[] { checkBox18.Text };

                quantityQ.Add(textBox4.Text);
                drinksD.Add(checkBox18.Text);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite - Can");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox19.Text;
                drinkQuant = textBox5.Text;
                allDrinks = new string[] { checkBox19.Text };

                quantityQ.Add(textBox5.Text);
                drinksD.Add(checkBox19.Text);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Root Beer - Can");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox20.Text;
                drinkQuant = textBox6.Text;
                allDrinks = new string[] { checkBox20.Text };

                quantityQ.Add(textBox6.Text);
                drinksD.Add(checkBox20.Text);
            }

            else
            {
                textBox6.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Bottled Water");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 1.25;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
                drinks = checkBox21.Text;
                drinkQuant = textBox7.Text;
                allDrinks = new string[] { checkBox21.Text };

                quantityQ.Add(textBox7.Text);
                drinksD.Add(checkBox21.Text);
            }

            else
            {
                textBox7.Text = "";
            }

            //Other Items Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Wings");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);
          otherItems = checkBox22.Text;

                otherit.Add(checkBox22.Text);
            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Poutine");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);
                otherItems = checkBox23.Text;

                otherit.Add(checkBox23.Text);
            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);
                otherItems = checkBox24.Text;

                otherit.Add(checkBox24.Text);
            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);
                otherItems = checkBox25.Text;

                otherit.Add(checkBox25.Text);
            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);
                otherItems = checkBox26.Text;

                otherit.Add(checkBox26.Text);
            }


            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("BBQ Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);
                otherItems = checkBox27.Text;

                otherit.Add(checkBox27.Text);
            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);
                otherItems = checkBox28.Text;

                otherit.Add(checkBox28.Text);
            }

  
            double total = 0;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            hst = total * 0.13;
            totaldue = hst + total;

            string hstDisplay = hst.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");
            
            textBox8.Text = amount;
            textBox9.Text = hstDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            foreach (string i in toppingsT)
            {
                t += $"{i}, ";
            }

            foreach (string i in drinksD)
            {
                d += $"{i}, ";
            }

            foreach (string i in quantityQ)
            {
                q += $"{i}, ";
            }

            foreach (string i in otherit)
            {
                o += $"{i}, ";
            }

            DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Express. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);


            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "INSERT INTO orders (pizza_size, crust, toppings, drinks, drink_quantity, other_items, username)VALUES('"+size+"', '"+crust+"', '"+t+"', '"+d+"', '"+q+"', '"+o+"', '"+username+"') ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
     
            if (dialog == DialogResult.Yes)
            {

           






                tabControl1.SelectTab("tabPage1");
            }

            else if (dialog == DialogResult.No)
            {
                Application.Exit();
                this.Close();
                
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;

            textBox21.Enabled = false;

            dashboardUser.Text = username;
            
    

           

            

        }

      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

      
        



        

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
} 
//cpfn
