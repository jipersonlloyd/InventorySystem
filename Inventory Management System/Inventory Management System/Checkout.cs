using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");

        private void Checkout_Load(object sender, EventArgs e)
        {
            RefreshInventory();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int _stocks = 0;
            int _quantity = 0;
            int _result = 0;
            string _prodID = productID.Text;
            _stocks = Convert.ToInt32(stocks.Text);
            _quantity = Convert.ToInt32(quantity.Text);

            _result = _stocks - _quantity;

            string query = "UPDATE Inventory SET Instock = '"+_result+"' WHERE id = '"+_prodID+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();
            ViewOrder vieworder = new ViewOrder();
            vieworder.Show();
            Thread.Sleep(500);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserContent usercontent = new UserContent();
            string query = "Delete OrderedItems";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();
            usercontent.Show();
            Thread.Sleep(500);
            this.Hide();
        }

        private void removeorder_Click(object sender, EventArgs e)
        {
            string prodID = productID.Text;
            string query = "DELETE FROM OrderedItems WHERE id = '" + prodID + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Product has been removed Successfully!", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            RefreshInventory();
            productID.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    productID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    quantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                    stocks.Text = dataGridView1.Rows[e.RowIndex].Cells["InStocks"].FormattedValue.ToString();
                }
            }
            catch
            {
                productID.Focus();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
