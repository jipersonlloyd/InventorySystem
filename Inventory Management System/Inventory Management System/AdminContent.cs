using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AdminContent : Form
    {
        public AdminContent()
        {
            InitializeComponent();
        }
        private void add_UControls(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void btn_click(Object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;
            }

            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "additembtn":
                    add_UControls(new UCAddItem());
                    addpnl.BackColor = Color.MediumSeaGreen;
                    break;
                case "editbtn":
                    add_UControls(new UCUpdateItem());
                    editpnl.BackColor = Color.MediumSeaGreen;
                    break;
                case "deletebtn":
                    add_UControls(new UCDeleteItem());
                    deletepnl.BackColor = Color.MediumSeaGreen;
                    break;
            }
        }
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            Thread.Sleep(500);
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdminContent_Load(object sender, EventArgs e)
        {

        }
        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
