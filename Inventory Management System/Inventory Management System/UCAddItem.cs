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
    public partial class UCAddItem : UserControl
    {
        public UCAddItem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RC1RFKK\SQLEXPRESS01;Initial Catalog=Accounts;Integrated Security=True");

        private void addbtn_Click(object sender, EventArgs e)
        {
            string _brand = brand.Text;
            string _model = model.Text;
            string _instock = instock.Text;
            string _price = price.Text;

            if (_brand != string.Empty && _model != string.Empty && _instock != string.Empty && _price != string.Empty)
            {
                string query = "INSERT INTO Inventory(Model, Brand, InStock, Price) VALUES('" + _model + "', '" + _brand + "', '" + _instock + "', '" + _price + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("The Item has been added successfully!", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                RefreshInventory();
                ClearTextboxes();
            }
            else
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextboxes();
            }


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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Inventory()
        {
            try
            {
                RefreshInventory();
            }
            catch { }
        }
        private void UCAddItem_Load(object sender, EventArgs e)
        {
            Inventory();
        }
        public void ClearTextboxes()
        {
            brand.Clear();
            model.Clear();
            instock.Clear();
            price.Clear();
            brand.Focus();
        }
    }
}
