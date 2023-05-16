namespace Inventory_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            here = new LinkLabel();
            label4 = new Label();
            firstname = new TextBox();
            midname = new TextBox();
            label5 = new Label();
            lastname = new TextBox();
            label6 = new Label();
            email = new TextBox();
            label7 = new Label();
            password = new TextBox();
            label8 = new Label();
            label9 = new Label();
            gender = new ComboBox();
            createaccntbtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 59);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 107);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 1;
            label2.Text = "Already have account?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 107);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // here
            // 
            here.AutoSize = true;
            here.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            here.LinkColor = Color.FromArgb(255, 128, 255);
            here.Location = new Point(247, 107);
            here.Name = "here";
            here.Size = new Size(38, 20);
            here.TabIndex = 3;
            here.TabStop = true;
            here.Text = "here";
            here.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 159);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "First Name ";
            // 
            // firstname
            // 
            firstname.BorderStyle = BorderStyle.None;
            firstname.ForeColor = Color.Black;
            firstname.Location = new Point(172, 162);
            firstname.Name = "firstname";
            firstname.PlaceholderText = "First";
            firstname.Size = new Size(150, 16);
            firstname.TabIndex = 5;
            firstname.TextChanged += textBox1_TextChanged;
            // 
            // midname
            // 
            midname.BorderStyle = BorderStyle.None;
            midname.ForeColor = Color.Black;
            midname.Location = new Point(172, 203);
            midname.Name = "midname";
            midname.PlaceholderText = "Middle";
            midname.Size = new Size(150, 16);
            midname.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 200);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 6;
            label5.Text = "Middle Name ";
            label5.Click += label5_Click;
            // 
            // lastname
            // 
            lastname.BorderStyle = BorderStyle.None;
            lastname.ForeColor = Color.Black;
            lastname.Location = new Point(172, 244);
            lastname.Name = "lastname";
            lastname.PlaceholderText = "Last";
            lastname.Size = new Size(150, 16);
            lastname.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(49, 241);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 8;
            label6.Text = "Last Name ";
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.None;
            email.ForeColor = Color.Black;
            email.Location = new Point(172, 285);
            email.Name = "email";
            email.PlaceholderText = "E-mail Address";
            email.Size = new Size(150, 16);
            email.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(49, 284);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 10;
            label7.Text = "E-mail Address ";
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.ForeColor = Color.Black;
            password.Location = new Point(172, 326);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(150, 16);
            password.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(49, 326);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 12;
            label8.Text = "Password ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(49, 366);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 14;
            label9.Text = "Gender";
            // 
            // gender
            // 
            gender.FlatStyle = FlatStyle.Flat;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            gender.Location = new Point(172, 363);
            gender.Name = "gender";
            gender.Size = new Size(150, 23);
            gender.TabIndex = 15;
            gender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // createaccntbtn
            // 
            createaccntbtn.BackColor = Color.Transparent;
            createaccntbtn.BackgroundImage = (Image)resources.GetObject("createaccntbtn.BackgroundImage");
            createaccntbtn.BackgroundImageLayout = ImageLayout.Stretch;
            createaccntbtn.FlatAppearance.BorderSize = 0;
            createaccntbtn.FlatStyle = FlatStyle.Flat;
            createaccntbtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            createaccntbtn.ForeColor = Color.Transparent;
            createaccntbtn.Location = new Point(75, 417);
            createaccntbtn.Name = "createaccntbtn";
            createaccntbtn.Size = new Size(175, 44);
            createaccntbtn.TabIndex = 25;
            createaccntbtn.Text = "Create Account";
            createaccntbtn.UseVisualStyleBackColor = false;
            createaccntbtn.Click += createaccntbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(164, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(164, 234);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(164, 275);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(165, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(164, 316);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(165, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(164, 357);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(165, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(413, -30);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(423, 629);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(814, 566);
            Controls.Add(pictureBox7);
            Controls.Add(createaccntbtn);
            Controls.Add(gender);
            Controls.Add(label9);
            Controls.Add(password);
            Controls.Add(label8);
            Controls.Add(email);
            Controls.Add(label7);
            Controls.Add(lastname);
            Controls.Add(label6);
            Controls.Add(midname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(here);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(firstname);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel here;
        private Label label4;
        private TextBox midname;
        private Label label5;
        private TextBox lastname;
        private Label label6;
        private TextBox email;
        private Label label7;
        private TextBox password;
        private Label label8;
        private Label label9;
        private ComboBox gender;
        private Button createaccntbtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox firstname;
        private PictureBox pictureBox7;
    }
}