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

namespace Inventory_Management_System
{
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");


        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            string query = "Delete OrderedItems";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();
            loginpage.Show();
            Thread.Sleep(500);
            this.Hide();

        }

        private void neworderbtn_Click(object sender, EventArgs e)
        {
            string query = "Delete OrderedItems";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();
            UserContent usercontent = new UserContent();
            usercontent.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    productID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                }
            }
            catch
            {
                productID.Focus();
            }
        }
        public void RefreshInventory()
        {
            conn.Open();
            string query = "SELECT * FROM OrderedItems";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            RefreshInventory();
        }

        private void receiptbtn_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;

            DialogResult result = printdialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Example Receipt", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

    }
}
