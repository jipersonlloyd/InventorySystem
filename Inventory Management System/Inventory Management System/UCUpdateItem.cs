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
    public partial class UCUpdateItem : UserControl
    {
        public UCUpdateItem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");
        private void UCEditItem_Load(object sender, EventArgs e)
        {
            Inventory();
        }
        void Inventory()
        {
            try
            {
                RefreshInventory();
            }
            catch { }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            string prodID = productID.Text;
            string brand = ebrand.Text;
            string model = emodel.Text;
            string instock = estock.Text;
            string price = eprice.Text;
            string query = "UPDATE Inventory SET Brand = '" + brand + "', Model = '" + model + "', InStock = '" + instock + "', Price = '" + price + "' WHERE id = '" + prodID + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("Product has been updated successfully", "Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshInventory();
            ClearTextboxes();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                productID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                ebrand.Text = dataGridView1.Rows[e.RowIndex].Cells["Brand"].FormattedValue.ToString();
                emodel.Text = dataGridView1.Rows[e.RowIndex].Cells["Model"].FormattedValue.ToString();
                estock.Text = dataGridView1.Rows[e.RowIndex].Cells["InStock"].FormattedValue.ToString();
                eprice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }
        public void ClearTextboxes()
        {
            productID.Clear();
            ebrand.Clear();
            emodel.Clear();
            estock.Clear();
            eprice.Clear();
        }
    }
}
