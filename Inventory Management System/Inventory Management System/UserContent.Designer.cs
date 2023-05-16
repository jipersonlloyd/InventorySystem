namespace Inventory_Management_System
{
    partial class UserContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserContent));
            fbrandcombobox = new ComboBox();
            label6 = new Label();
            checkoutbtn = new Button();
            panel1 = new Panel();
            searchbtn = new Button();
            fmodeltextbox = new TextBox();
            brand = new TextBox();
            label5 = new Label();
            productID = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            addtocartbtn = new Button();
            dataGridView1 = new DataGridView();
            price = new TextBox();
            instock = new TextBox();
            model = new TextBox();
            label3 = new Label();
            logoutbtn = new Button();
            label7 = new Label();
            quantity = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // fbrandcombobox
            // 
            fbrandcombobox.FormattingEnabled = true;
            fbrandcombobox.Items.AddRange(new object[] { "Samsung", "Apple", "Xiaomi", "Huawei", "OnePlus", "OPPO", "Nokia", "Vivo" });
            fbrandcombobox.Location = new Point(229, 52);
            fbrandcombobox.Name = "fbrandcombobox";
            fbrandcombobox.Size = new Size(139, 23);
            fbrandcombobox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(229, 23);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 1;
            label6.Text = "Find Items";
            // 
            // checkoutbtn
            // 
            checkoutbtn.BackColor = Color.Transparent;
            checkoutbtn.BackgroundImage = (Image)resources.GetObject("checkoutbtn.BackgroundImage");
            checkoutbtn.BackgroundImageLayout = ImageLayout.Stretch;
            checkoutbtn.FlatAppearance.BorderSize = 0;
            checkoutbtn.FlatStyle = FlatStyle.Flat;
            checkoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkoutbtn.ForeColor = SystemColors.ControlLightLight;
            checkoutbtn.Location = new Point(759, 481);
            checkoutbtn.Name = "checkoutbtn";
            checkoutbtn.Size = new Size(164, 38);
            checkoutbtn.TabIndex = 65;
            checkoutbtn.Text = "            CHECKOUT";
            checkoutbtn.TextAlign = ContentAlignment.MiddleLeft;
            checkoutbtn.UseVisualStyleBackColor = false;
            checkoutbtn.Click += checkoutbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(searchbtn);
            panel1.Controls.Add(fbrandcombobox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(fmodeltextbox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 100);
            panel1.TabIndex = 64;
            // 
            // searchbtn
            // 
            searchbtn.BackgroundImage = (Image)resources.GetObject("searchbtn.BackgroundImage");
            searchbtn.BackgroundImageLayout = ImageLayout.Stretch;
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.CornflowerBlue;
            searchbtn.Location = new Point(587, 44);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(43, 37);
            searchbtn.TabIndex = 50;
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click_1;
            // 
            // fmodeltextbox
            // 
            fmodeltextbox.Location = new Point(374, 52);
            fmodeltextbox.Name = "fmodeltextbox";
            fmodeltextbox.Size = new Size(207, 23);
            fmodeltextbox.TabIndex = 3;
            // 
            // brand
            // 
            brand.Location = new Point(97, 188);
            brand.Name = "brand";
            brand.ReadOnly = true;
            brand.Size = new Size(100, 23);
            brand.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 149);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 63;
            label5.Text = "Product ID";
            // 
            // productID
            // 
            productID.Location = new Point(97, 149);
            productID.Name = "productID";
            productID.ReadOnly = true;
            productID.Size = new Size(100, 23);
            productID.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 313);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 61;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 229);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 59;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 190);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 58;
            label1.Text = "Brand";
            // 
            // addtocartbtn
            // 
            addtocartbtn.BackColor = Color.Transparent;
            addtocartbtn.BackgroundImage = (Image)resources.GetObject("addtocartbtn.BackgroundImage");
            addtocartbtn.BackgroundImageLayout = ImageLayout.Stretch;
            addtocartbtn.FlatAppearance.BorderSize = 0;
            addtocartbtn.FlatStyle = FlatStyle.Flat;
            addtocartbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addtocartbtn.Location = new Point(759, 439);
            addtocartbtn.Name = "addtocartbtn";
            addtocartbtn.Size = new Size(164, 36);
            addtocartbtn.TabIndex = 57;
            addtocartbtn.UseVisualStyleBackColor = false;
            addtocartbtn.Click += addtocartbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(223, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(517, 371);
            dataGridView1.TabIndex = 56;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // price
            // 
            price.Location = new Point(97, 311);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(100, 23);
            price.TabIndex = 55;
            // 
            // instock
            // 
            instock.Location = new Point(97, 271);
            instock.Name = "instock";
            instock.ReadOnly = true;
            instock.Size = new Size(100, 23);
            instock.TabIndex = 54;
            // 
            // model
            // 
            model.Location = new Point(97, 228);
            model.Name = "model";
            model.ReadOnly = true;
            model.Size = new Size(100, 23);
            model.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 273);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 60;
            label3.Text = "Stock";
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Transparent;
            logoutbtn.BackgroundImage = (Image)resources.GetObject("logoutbtn.BackgroundImage");
            logoutbtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.Location = new Point(34, 475);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(130, 44);
            logoutbtn.TabIndex = 66;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 353);
            label7.Name = "label7";
            label7.Size = new Size(55, 16);
            label7.TabIndex = 68;
            label7.Text = "Quantity";
            // 
            // quantity
            // 
            quantity.Location = new Point(97, 351);
            quantity.Name = "quantity";
            quantity.Size = new Size(100, 23);
            quantity.TabIndex = 67;
            // 
            // UserContent
            // 
            AcceptButton = searchbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(945, 566);
            Controls.Add(label7);
            Controls.Add(quantity);
            Controls.Add(logoutbtn);
            Controls.Add(checkoutbtn);
            Controls.Add(panel1);
            Controls.Add(brand);
            Controls.Add(label5);
            Controls.Add(productID);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addtocartbtn);
            Controls.Add(dataGridView1);
            Controls.Add(price);
            Controls.Add(instock);
            Controls.Add(model);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserContent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserContent";
            Load += UserContent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox fbrandcombobox;
        private Label label6;
        private Button checkoutbtn;
        private Panel panel1;
        private Button searchbtn;
        private TextBox fmodeltextbox;
        private Label label5;
        private TextBox productID;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button addtocartbtn;
        private DataGridView dataGridView1;
        private TextBox price;
        private TextBox instock;
        private TextBox model;
        private TextBox brand;
        private Label label3;
        private Button logoutbtn;
        private Label label7;
        private TextBox quantity;
    }
}