using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class UserContent : Form
    {
        public UserContent()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    productID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    brand.Text = dataGridView1.Rows[e.RowIndex].Cells["Brand"].FormattedValue.ToString();
                    model.Text = dataGridView1.Rows[e.RowIndex].Cells["Model"].FormattedValue.ToString();
                    instock.Text = dataGridView1.Rows[e.RowIndex].Cells["InStock"].FormattedValue.ToString();
                    price.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                }
            }
            catch
            {
                fmodeltextbox.Focus();
            }
        }
        public void Inventory()
        {
            try
            {
                RefreshInventory();
            }
            catch { }
        }
        public void RefreshInventory()
        {
            conn.Open();
            string query = "SELECT * FROM Inventory";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void UserContent_Load(object sender, EventArgs e)
        {
            Inventory();
        }
        public void SearchItem(string branditem, string modelitem)
        {
            string query = "SELECT * FROM Inventory WHERE CONCAT(Brand, Model) LIKE '%" + branditem + "%' + '%" + modelitem + "%'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            string findbrand = fbrandcombobox.Text.ToString();
            string findmodel = fmodeltextbox.Text.ToString();
            SearchItem(findbrand, findmodel);
        }

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

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
            Thread.Sleep(500);
            this.Hide();
        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            string prodID = productID.Text;
            string _brand = brand.Text;
            string _model = model.Text;
            string _price = price.Text;
            string _quantity = quantity.Text;
            string _stock = instock.Text;
            try
            {
                if (_quantity != string.Empty)
                {
                    string query = "INSERT INTO OrderedItems(id, Brand, Model, Price, Quantity, InStocks) VALUES('" + prodID + "', '" + _brand + "', '" + _model + "', '" + _price + "', '" + _quantity + "', '"+_stock+"')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Item has been added to Cart!", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    ClearTextboxes();
                }
                else
                {
                    MessageBox.Show("Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Item is already added to the cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextboxes();
            }
        }
        public void ClearTextboxes()
        {
            brand.Clear();
            model.Clear();
            instock.Clear();
            price.Clear();
            productID.Clear();
            quantity.Clear();
            quantity.Focus();
        }
    }
}
