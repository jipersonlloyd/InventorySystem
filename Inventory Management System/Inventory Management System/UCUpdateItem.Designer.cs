namespace Inventory_Management_System
{
    partial class UCUpdateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUpdateItem));
            editbtn = new Button();
            dataGridView1 = new DataGridView();
            eprice = new TextBox();
            label4 = new Label();
            estock = new TextBox();
            label3 = new Label();
            emodel = new TextBox();
            label2 = new Label();
            ebrand = new TextBox();
            label1 = new Label();
            productID = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.Transparent;
            editbtn.BackgroundImage = (Image)resources.GetObject("editbtn.BackgroundImage");
            editbtn.BackgroundImageLayout = ImageLayout.Stretch;
            editbtn.FlatAppearance.BorderSize = 0;
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.Location = new Point(45, 380);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(119, 37);
            editbtn.TabIndex = 19;
            editbtn.Text = "Edit Item";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += addbtn_Click;
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
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // eprice
            // 
            eprice.Location = new Point(94, 326);
            eprice.Name = "eprice";
            eprice.Size = new Size(100, 23);
            eprice.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 328);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 16;
            label4.Text = "Price";
            // 
            // estock
            // 
            estock.Location = new Point(94, 286);
            estock.Name = "estock";
            estock.Size = new Size(100, 23);
            estock.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 288);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 14;
            label3.Text = "Stock";
            // 
            // emodel
            // 
            emodel.Location = new Point(94, 243);
            emodel.Name = "emodel";
            emodel.Size = new Size(100, 23);
            emodel.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 244);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 12;
            label2.Text = "Model";
            // 
            // ebrand
            // 
            ebrand.Location = new Point(94, 203);
            ebrand.Name = "ebrand";
            ebrand.Size = new Size(100, 23);
            ebrand.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 205);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 10;
            label1.Text = "Brand";
            // 
            // productID
            // 
            productID.Location = new Point(94, 164);
            productID.Name = "productID";
            productID.ReadOnly = true;
            productID.Size = new Size(100, 23);
            productID.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 164);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 20;
            label5.Text = "Product ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 100);
            panel1.TabIndex = 24;
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
            // UCUpdateItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(productID);
            Controls.Add(label5);
            Controls.Add(editbtn);
            Controls.Add(dataGridView1);
            Controls.Add(eprice);
            Controls.Add(label4);
            Controls.Add(estock);
            Controls.Add(label3);
            Controls.Add(emodel);
            Controls.Add(label2);
            Controls.Add(ebrand);
            Controls.Add(label1);
            Name = "UCUpdateItem";
            Size = new Size(768, 566);
            Load += UCEditItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editbtn;
        private DataGridView dataGridView1;
        private TextBox eprice;
        private Label label4;
        private TextBox estock;
        private Label label3;
        private TextBox emodel;
        private Label label2;
        private TextBox ebrand;
        private Label label1;
        private TextBox productID;
        private Label label5;
        private Panel panel1;
        private Label label6;
    }
}
