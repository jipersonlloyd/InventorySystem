namespace Inventory_Management_System
{
    partial class AdminContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminContent));
            pnltop = new Panel();
            logoutbtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            deletepnl = new Panel();
            deletebtn = new Button();
            editpnl = new Panel();
            editbtn = new Button();
            addpnl = new Panel();
            additembtn = new Button();
            pnlmain = new Panel();
            pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            deletepnl.SuspendLayout();
            editpnl.SuspendLayout();
            addpnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnltop
            // 
            pnltop.BackColor = Color.Silver;
            pnltop.Controls.Add(logoutbtn);
            pnltop.Controls.Add(label1);
            pnltop.Controls.Add(pictureBox1);
            pnltop.Controls.Add(tableLayoutPanel1);
            pnltop.Location = new Point(0, 0);
            pnltop.Name = "pnltop";
            pnltop.Size = new Size(178, 566);
            pnltop.TabIndex = 0;
            pnltop.Paint += panel1_Paint;
            // 
            // logoutbtn
            // 
            logoutbtn.BackgroundImage = (Image)resources.GetObject("logoutbtn.BackgroundImage");
            logoutbtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.Location = new Point(21, 497);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(130, 44);
            logoutbtn.TabIndex = 1;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 0;
            label1.Text = "WareTechs";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(deletepnl, 0, 2);
            tableLayoutPanel1.Controls.Add(editpnl, 0, 1);
            tableLayoutPanel1.Controls.Add(addpnl, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.334446F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3311157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(178, 229);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // deletepnl
            // 
            deletepnl.BackColor = Color.Silver;
            deletepnl.Controls.Add(deletebtn);
            deletepnl.Dock = DockStyle.Fill;
            deletepnl.Location = new Point(5, 157);
            deletepnl.Margin = new Padding(5);
            deletepnl.Name = "deletepnl";
            deletepnl.Padding = new Padding(5, 0, 0, 0);
            deletepnl.Size = new Size(168, 67);
            deletepnl.TabIndex = 6;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Silver;
            deletebtn.Dock = DockStyle.Fill;
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Image = (Image)resources.GetObject("deletebtn.Image");
            deletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            deletebtn.Location = new Point(5, 0);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(163, 67);
            deletebtn.TabIndex = 1;
            deletebtn.Text = "      Delete Item";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += btn_click;
            // 
            // editpnl
            // 
            editpnl.BackColor = Color.Silver;
            editpnl.Controls.Add(editbtn);
            editpnl.Dock = DockStyle.Fill;
            editpnl.Location = new Point(5, 81);
            editpnl.Margin = new Padding(5);
            editpnl.Name = "editpnl";
            editpnl.Padding = new Padding(5, 0, 0, 0);
            editpnl.Size = new Size(168, 66);
            editpnl.TabIndex = 5;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.Silver;
            editbtn.Dock = DockStyle.Fill;
            editbtn.FlatAppearance.BorderSize = 0;
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.Image = (Image)resources.GetObject("editbtn.Image");
            editbtn.ImageAlign = ContentAlignment.MiddleLeft;
            editbtn.Location = new Point(5, 0);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(163, 66);
            editbtn.TabIndex = 1;
            editbtn.Text = "       Update Item";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += btn_click;
            // 
            // addpnl
            // 
            addpnl.BackColor = Color.Silver;
            addpnl.Controls.Add(additembtn);
            addpnl.Dock = DockStyle.Fill;
            addpnl.Location = new Point(5, 5);
            addpnl.Margin = new Padding(5);
            addpnl.Name = "addpnl";
            addpnl.Padding = new Padding(5, 0, 0, 0);
            addpnl.Size = new Size(168, 66);
            addpnl.TabIndex = 4;
            // 
            // additembtn
            // 
            additembtn.BackColor = Color.Silver;
            additembtn.Dock = DockStyle.Fill;
            additembtn.FlatAppearance.BorderSize = 0;
            additembtn.FlatStyle = FlatStyle.Flat;
            additembtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            additembtn.Image = (Image)resources.GetObject("additembtn.Image");
            additembtn.ImageAlign = ContentAlignment.MiddleLeft;
            additembtn.Location = new Point(5, 0);
            additembtn.Name = "additembtn";
            additembtn.Size = new Size(163, 66);
            additembtn.TabIndex = 1;
            additembtn.Text = "  Add Item";
            additembtn.UseVisualStyleBackColor = false;
            additembtn.Click += btn_click;
            // 
            // pnlmain
            // 
            pnlmain.BackgroundImageLayout = ImageLayout.Stretch;
            pnlmain.Location = new Point(178, 0);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(768, 566);
            pnlmain.TabIndex = 1;
            pnlmain.Paint += pnlmain_Paint;
            // 
            // AdminContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(945, 566);
            Controls.Add(pnlmain);
            Controls.Add(pnltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminContent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += AdminContent_Load;
            pnltop.ResumeLayout(false);
            pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            deletepnl.ResumeLayout(false);
            editpnl.ResumeLayout(false);
            addpnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltop;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel addpnl;
        private Button additembtn;
        private Panel deletepnl;
        private Button deletebtn;
        private Panel editpnl;
        private Button editbtn;
        private Panel pnlmain;
        private PictureBox pictureBox1;
        private Label label1;
        private Button logoutbtn;
    }
}