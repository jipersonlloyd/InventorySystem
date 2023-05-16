using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Form2 : Form
    {
        Form1 loginpage = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");

        private void createaccntbtn_Click(object sender, EventArgs e)
        {
            string frstname = firstname.Text;
            string lstname = lastname.Text;
            string mdname = midname.Text;
            string gendr = gender.Text;
            string emailadd = email.Text;
            string pass = password.Text;

            try
            {
                string query = "INSERT INTO CreateAccount(FirstName, MiddleName, LastName, EmailAddress, Password, Gender) VALUES('" + frstname + "', '" + mdname + "', '" + lstname + "', '" + emailadd + "', '" + pass + "', '" + gendr + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();

                if (frstname != string.Empty && lstname != string.Empty && gendr != string.Empty && emailadd != string.Empty && pass != string.Empty)
                {
                    sda.Fill(dtable);
                    MessageBox.Show("Account Created Successfully!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginpage.Show();
                    Thread.Sleep(500);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginpage.Show();
            Thread.Sleep(500);
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
