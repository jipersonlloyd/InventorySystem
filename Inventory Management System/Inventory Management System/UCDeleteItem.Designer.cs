namespace Inventory_Management_System
{
    partial class UCDeleteItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDeleteItem));
            deletebtn = new Button();
            dataGridView1 = new DataGridView();
            price = new TextBox();
            instock = new TextBox();
            model = new TextBox();
            brand = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            productID = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Transparent;
            deletebtn.BackgroundImage = (Image)resources.GetObject("deletebtn.BackgroundImage");
            deletebtn.BackgroundImageLayout = ImageLayout.Stretch;
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Location = new Point(45, 380);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(119, 37);
            deletebtn.TabIndex = 29;
            deletebtn.Text = "Delete Item";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += addbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(517, 371);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // price
            // 
            price.Location = new Point(94, 326);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(100, 23);
            price.TabIndex = 27;
            // 
            // instock
            // 
            instock.Location = new Point(94, 286);
            instock.Name = "instock";
            instock.ReadOnly = true;
            instock.Size = new Size(100, 23);
            instock.TabIndex = 25;
            // 
            // model
            // 
            model.Location = new Point(94, 243);
            model.Name = "model";
            model.ReadOnly = true;
            model.Size = new Size(100, 23);
            model.TabIndex = 23;
            // 
            // brand
            // 
            brand.Location = new Point(94, 203);
            brand.Name = "brand";
            brand.ReadOnly = true;
            brand.Size = new Size(100, 23);
            brand.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 328);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 33;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 288);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 32;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 244);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 31;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 205);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 30;
            label1.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 164);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 35;
            label5.Text = "Product ID";
            // 
            // productID
            // 
            productID.Location = new Point(94, 164);
            productID.Name = "productID";
            productID.ReadOnly = true;
            productID.Size = new Size(100, 23);
            productID.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 100);
            panel1.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(175, 33);
            label6.Name = "label6";
            label6.Size = new Size(431, 32);
            label6.TabIndex = 0;
            label6.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // UCDeleteItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(productID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deletebtn);
            Controls.Add(dataGridView1);
            Controls.Add(price);
            Controls.Add(instock);
            Controls.Add(model);
            Controls.Add(brand);
            Name = "UCDeleteItem";
            Size = new Size(768, 566);
            Load += UCDeleteItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deletebtn;
        private DataGridView dataGridView1;
        private TextBox price;
        private TextBox instock;
        private TextBox model;
        private TextBox brand;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox productID;
        private Panel panel1;
        private Label label6;
    }
}
