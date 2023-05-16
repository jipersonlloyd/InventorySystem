using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = pictureBox1.PointToClient(PointToScreen(label1.Location));
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Location = pictureBox1.PointToClient(PointToScreen(label2.Location));
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Location = pictureBox1.PointToClient(PointToScreen(label3.Location));
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Location = pictureBox1.PointToClient(PointToScreen(label4.Location));
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            pictureBox2.Location = pictureBox1.PointToClient(PointToScreen(pictureBox2.Location));
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email_address, user_password;

            user_password = password.Text;
            email_address = emailaddress.Text;
            try
            {
                string query = "SELECT * FROM CreateAccount WHERE emailaddress = '" + email_address + "' AND password = '" + user_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email_address = emailaddress.Text;
                    user_password = password.Text;

                    if (email_address.Contains("admin"))
                    {
                        AdminContent form3 = new AdminContent();
                        form3.Show();
                        Thread.Sleep(500);
                        this.Hide();
                    }
                    else
                    {
                        UserContent usercontent = new UserContent();
                        usercontent.Show();
                        Thread.Sleep(500);
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailaddress.Clear();
                    password.Clear();
                    emailaddress.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 createaccount = new Form2();
            createaccount.Show();
            Thread.Sleep(500);
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}