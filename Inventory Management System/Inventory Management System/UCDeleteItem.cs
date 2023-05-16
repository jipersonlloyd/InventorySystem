using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Inventory_Management_System
{
    public partial class UCDeleteItem : UserControl
    {
        public UCDeleteItem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");
        private void UCDeleteItem_Load(object sender, EventArgs e)
        {
            Inventory();
        }
        public void ClearTextboxes()
        {
            productID.Clear();
            brand.Clear();
            model.Clear();
            instock.Clear();
            price.Clear();
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

        private void addbtn_Click(object sender, EventArgs e)
        {
            string prodID = productID.Text;
            string query = "DELETE FROM Inventory WHERE id = '" + prodID + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Product has been deleted Successfully!", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            RefreshInventory();
            ClearTextboxes();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
