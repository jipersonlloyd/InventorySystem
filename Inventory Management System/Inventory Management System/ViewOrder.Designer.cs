namespace Inventory_Management_System
{
    partial class ViewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrder));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            logoutbtn = new Button();
            productID = new TextBox();
            neworderbtn = new Button();
            receiptbtn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(607, 330);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(341, 483);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 1;
            label1.Text = "Product ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-301, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Transparent;
            logoutbtn.BackgroundImage = (Image)resources.GetObject("logoutbtn.BackgroundImage");
            logoutbtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.Location = new Point(491, 51);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(155, 52);
            logoutbtn.TabIndex = 5;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // productID
            // 
            productID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            productID.Location = new Point(421, 480);
            productID.Name = "productID";
            productID.Size = new Size(64, 25);
            productID.TabIndex = 6;
            // 
            // neworderbtn
            // 
            neworderbtn.BackColor = Color.Transparent;
            neworderbtn.BackgroundImage = (Image)resources.GetObject("neworderbtn.BackgroundImage");
            neworderbtn.BackgroundImageLayout = ImageLayout.Stretch;
            neworderbtn.FlatAppearance.BorderSize = 0;
            neworderbtn.FlatStyle = FlatStyle.Flat;
            neworderbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            neworderbtn.Location = new Point(330, 51);
            neworderbtn.Name = "neworderbtn";
            neworderbtn.Size = new Size(155, 52);
            neworderbtn.TabIndex = 7;
            neworderbtn.Text = "New Order";
            neworderbtn.UseVisualStyleBackColor = false;
            neworderbtn.Click += neworderbtn_Click;
            // 
            // receiptbtn
            // 
            receiptbtn.BackColor = Color.Transparent;
            receiptbtn.BackgroundImage = (Image)resources.GetObject("receiptbtn.BackgroundImage");
            receiptbtn.BackgroundImageLayout = ImageLayout.Stretch;
            receiptbtn.FlatAppearance.BorderSize = 0;
            receiptbtn.FlatStyle = FlatStyle.Flat;
            receiptbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            receiptbtn.Location = new Point(491, 465);
            receiptbtn.Name = "receiptbtn";
            receiptbtn.Size = new Size(155, 52);
            receiptbtn.TabIndex = 8;
            receiptbtn.Text = "Print Receipt";
            receiptbtn.UseVisualStyleBackColor = false;
            receiptbtn.Click += receiptbtn_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // ViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(690, 566);
            Controls.Add(receiptbtn);
            Controls.Add(neworderbtn);
            Controls.Add(productID);
            Controls.Add(logoutbtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrder";
            Load += ViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button logoutbtn;
        private TextBox productID;
        private Button neworderbtn;
        private Button receiptbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}