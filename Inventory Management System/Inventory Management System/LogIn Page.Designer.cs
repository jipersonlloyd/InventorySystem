namespace Inventory_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            emailaddress = new TextBox();
            password = new TextBox();
            pictureBox6 = new PictureBox();
            checkBox1 = new CheckBox();
            pictureBox8 = new PictureBox();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            loginbtn = new Button();
            exitbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 852);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(150, 264);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(132, 296);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 2;
            label2.Text = "Management";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(164, 328);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 3;
            label3.Text = "System";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(184, 209);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 4;
            label4.Text = "WareTechs";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(110, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(589, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // emailaddress
            // 
            emailaddress.BackColor = Color.White;
            emailaddress.BorderStyle = BorderStyle.None;
            emailaddress.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailaddress.ForeColor = Color.Black;
            emailaddress.Location = new Point(573, 237);
            emailaddress.Multiline = true;
            emailaddress.Name = "emailaddress";
            emailaddress.PlaceholderText = "E-mail Address";
            emailaddress.Size = new Size(179, 23);
            emailaddress.TabIndex = 9;
            emailaddress.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.Location = new Point(573, 305);
            password.Multiline = true;
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(179, 23);
            password.TabIndex = 11;
            password.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(545, 236);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.DimGray;
            checkBox1.Location = new Point(589, 352);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 21);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Keep Me Login";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(545, 302);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(22, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(564, 452);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 18;
            label6.Text = "New User ? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(255, 128, 255);
            linkLabel1.Location = new Point(636, 452);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(691, 451);
            label7.Name = "label7";
            label7.Size = new Size(36, 17);
            label7.TabIndex = 20;
            label7.Text = "Here";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(545, 193);
            label8.Name = "label8";
            label8.Size = new Size(194, 16);
            label8.TabIndex = 21;
            label8.Text = "Get Started from Login Below";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.WhiteSmoke;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(532, 225);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(229, 42);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.WhiteSmoke;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(532, 292);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(229, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Transparent;
            loginbtn.BackgroundImage = (Image)resources.GetObject("loginbtn.BackgroundImage");
            loginbtn.BackgroundImageLayout = ImageLayout.Stretch;
            loginbtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.Transparent;
            loginbtn.Location = new Point(564, 392);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(175, 44);
            loginbtn.TabIndex = 24;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackgroundImageLayout = ImageLayout.Stretch;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.ForeColor = Color.WhiteSmoke;
            exitbtn.Image = (Image)resources.GetObject("exitbtn.Image");
            exitbtn.Location = new Point(752, 12);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(50, 44);
            exitbtn.TabIndex = 25;
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = loginbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(814, 566);
            Controls.Add(exitbtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(pictureBox8);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox6);
            Controls.Add(password);
            Controls.Add(emailaddress);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox4);
            Controls.Add(loginbtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox emailaddress;
        private TextBox password;
        private PictureBox pictureBox6;
        private CheckBox checkBox1;
        private PictureBox pictureBox8;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private Button loginbtn;
        private Button exitbtn;
    }
}