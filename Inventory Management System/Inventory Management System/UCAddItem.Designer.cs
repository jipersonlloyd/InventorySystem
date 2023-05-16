namespace Inventory_Management_System
{
    partial class UCAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddItem));
            label1 = new Label();
            brand = new TextBox();
            model = new TextBox();
            label2 = new Label();
            instock = new TextBox();
            label3 = new Label();
            price = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            addbtn = new Button();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 165);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // brand
            // 
            brand.Location = new Point(95, 164);
            brand.Name = "brand";
            brand.Size = new Size(100, 23);
            brand.TabIndex = 1;
            // 
            // model
            // 
            model.Location = new Point(95, 206);
            model.Name = "model";
            model.Size = new Size(100, 23);
            model.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 207);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // instock
            // 
            instock.Location = new Point(95, 249);
            instock.Name = "instock";
            instock.Size = new Size(100, 23);
            instock.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 250);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 4;
            label3.Text = "InStock";
            // 
            // price
            // 
            price.Location = new Point(95, 289);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 290);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 6;
            label4.Text = "Price";
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
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Transparent;
            addbtn.BackgroundImage = (Image)resources.GetObject("addbtn.BackgroundImage");
            addbtn.BackgroundImageLayout = ImageLayout.Stretch;
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = SystemColors.ActiveCaptionText;
            addbtn.Location = new Point(46, 343);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(119, 37);
            addbtn.TabIndex = 9;
            addbtn.Text = "Add Item";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 100);
            panel1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(175, 33);
            label5.Name = "label5";
            label5.Size = new Size(431, 32);
            label5.TabIndex = 0;
            label5.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // UCAddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(addbtn);
            Controls.Add(dataGridView1);
            Controls.Add(price);
            Controls.Add(label4);
            Controls.Add(instock);
            Controls.Add(label3);
            Controls.Add(model);
            Controls.Add(label2);
            Controls.Add(brand);
            Controls.Add(label1);
            Name = "UCAddItem";
            Size = new Size(768, 566);
            Load += UCAddItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox brand;
        private TextBox model;
        private Label label2;
        private TextBox instock;
        private Label label3;
        private TextBox price;
        private Label label4;
        private DataGridView dataGridView1;
        private Button addbtn;
        private Panel panel1;
        private Label label5;
    }
}
