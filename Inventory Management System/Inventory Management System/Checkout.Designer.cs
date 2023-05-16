namespace Inventory_Management_System
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            dataGridView1 = new DataGridView();
            proceedbtn = new Button();
            cancelbtn = new Button();
            removeorder = new Button();
            productID = new TextBox();
            label1 = new Label();
            stocks = new TextBox();
            label2 = new Label();
            quantity = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(522, 256);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // proceedbtn
            // 
            proceedbtn.BackColor = Color.Transparent;
            proceedbtn.BackgroundImage = (Image)resources.GetObject("proceedbtn.BackgroundImage");
            proceedbtn.BackgroundImageLayout = ImageLayout.Stretch;
            proceedbtn.FlatAppearance.BorderSize = 0;
            proceedbtn.FlatStyle = FlatStyle.Flat;
            proceedbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            proceedbtn.ForeColor = SystemColors.ControlText;
            proceedbtn.Location = new Point(492, 432);
            proceedbtn.Name = "proceedbtn";
            proceedbtn.Size = new Size(115, 45);
            proceedbtn.TabIndex = 1;
            proceedbtn.Text = "Proceed Order";
            proceedbtn.UseVisualStyleBackColor = false;
            proceedbtn.Click += button1_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = Color.Transparent;
            cancelbtn.BackgroundImage = (Image)resources.GetObject("cancelbtn.BackgroundImage");
            cancelbtn.BackgroundImageLayout = ImageLayout.Stretch;
            cancelbtn.FlatAppearance.BorderSize = 0;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelbtn.ForeColor = SystemColors.ControlText;
            cancelbtn.Location = new Point(371, 432);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(115, 45);
            cancelbtn.TabIndex = 2;
            cancelbtn.Text = "Cancel Order";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += button2_Click;
            // 
            // removeorder
            // 
            removeorder.BackColor = Color.Transparent;
            removeorder.BackgroundImage = (Image)resources.GetObject("removeorder.BackgroundImage");
            removeorder.BackgroundImageLayout = ImageLayout.Stretch;
            removeorder.FlatAppearance.BorderSize = 0;
            removeorder.FlatStyle = FlatStyle.Flat;
            removeorder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeorder.ForeColor = SystemColors.ControlText;
            removeorder.Location = new Point(492, 103);
            removeorder.Name = "removeorder";
            removeorder.Size = new Size(115, 45);
            removeorder.TabIndex = 3;
            removeorder.Text = "Remove Order";
            removeorder.UseVisualStyleBackColor = false;
            removeorder.Click += removeorder_Click;
            // 
            // productID
            // 
            productID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            productID.Location = new Point(397, 113);
            productID.Name = "productID";
            productID.ReadOnly = true;
            productID.Size = new Size(74, 25);
            productID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 116);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 7;
            label1.Text = "Product ID";
            // 
            // stocks
            // 
            stocks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            stocks.Location = new Point(291, 442);
            stocks.Name = "stocks";
            stocks.ReadOnly = true;
            stocks.Size = new Size(74, 25);
            stocks.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 445);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 9;
            label2.Text = "Stocks";
            // 
            // quantity
            // 
            quantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            quantity.Location = new Point(153, 442);
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Size = new Size(74, 25);
            quantity.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 445);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 11;
            label3.Text = "Quantity";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(690, 566);
            ControlBox = false;
            Controls.Add(quantity);
            Controls.Add(label3);
            Controls.Add(stocks);
            Controls.Add(label2);
            Controls.Add(productID);
            Controls.Add(label1);
            Controls.Add(removeorder);
            Controls.Add(cancelbtn);
            Controls.Add(proceedbtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            Load += Checkout_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button proceedbtn;
        private Button cancelbtn;
        private Button removeorder;
        private TextBox productID;
        private Label label1;
        private TextBox stocks;
        private Label label2;
        private TextBox quantity;
        private Label label3;
    }
}