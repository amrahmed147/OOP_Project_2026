namespace BankProject
{
    partial class RegisterationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            txtPhoneNum = new TextBox();
            txtCardNum = new TextBox();
            txtCardHoldName = new TextBox();
            txtEXPdate = new TextBox();
            txtCCV = new TextBox();
            label9 = new Label();
            btnSave = new Button();
            linkLabel1 = new LinkLabel();
            AccountTypeBox = new ComboBox();
            label10 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 92);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 179);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 133);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 229);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 3;
            label4.Text = "Phone number: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 395);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 4;
            label5.Text = "Card Number:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(144, 504);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 5;
            label6.Text = "Exp. Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(47, 440);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 6;
            label7.Text = "Cardholder name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(186, 547);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 7;
            label8.Text = "CVV:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(144, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(152, 27);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 27);
            txtName.TabIndex = 10;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(144, 225);
            txtPhoneNum.MaxLength = 11;
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(152, 27);
            txtPhoneNum.TabIndex = 11;
            txtPhoneNum.KeyPress += txtPhoneNum_KeyPress;
            // 
            // txtCardNum
            // 
            txtCardNum.Location = new Point(200, 393);
            txtCardNum.MaxLength = 19;
            txtCardNum.Name = "txtCardNum";
            txtCardNum.Size = new Size(193, 27);
            txtCardNum.TabIndex = 12;
            txtCardNum.TextChanged += txtCardNum_TextChanged;
            txtCardNum.KeyPress += txtCardNum_KeyPress;
            // 
            // txtCardHoldName
            // 
            txtCardHoldName.Location = new Point(200, 440);
            txtCardHoldName.Name = "txtCardHoldName";
            txtCardHoldName.Size = new Size(193, 27);
            txtCardHoldName.TabIndex = 13;
            txtCardHoldName.KeyPress += txtCardHoldName_KeyPress;
            // 
            // txtEXPdate
            // 
            txtEXPdate.Location = new Point(241, 505);
            txtEXPdate.MaxLength = 2;
            txtEXPdate.Name = "txtEXPdate";
            txtEXPdate.Size = new Size(37, 27);
            txtEXPdate.TabIndex = 14;
            txtEXPdate.TextAlign = HorizontalAlignment.Center;
            txtEXPdate.KeyPress += txtEXPdate_KeyPress;
            // 
            // txtCCV
            // 
            txtCCV.Location = new Point(258, 548);
            txtCCV.MaxLength = 3;
            txtCCV.Name = "txtCCV";
            txtCCV.Size = new Size(77, 27);
            txtCCV.TabIndex = 15;
            txtCCV.TextAlign = HorizontalAlignment.Center;
            txtCCV.KeyPress += txtCCV_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(227, 332);
            label9.Name = "label9";
            label9.Size = new Size(140, 31);
            label9.TabIndex = 16;
            label9.Text = "Card Details";
            label9.Click += label9_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(187, 581);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 52);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(232, 647);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AccountTypeBox
            // 
            AccountTypeBox.FormattingEnabled = true;
            AccountTypeBox.Items.AddRange(new object[] { "Saving ", "Checking" });
            AccountTypeBox.Location = new Point(145, 277);
            AccountTypeBox.Name = "AccountTypeBox";
            AccountTypeBox.Size = new Size(151, 28);
            AccountTypeBox.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 278);
            label10.Name = "label10";
            label10.Size = new Size(122, 23);
            label10.TabIndex = 20;
            label10.Text = "Account Type: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCCV);
            panel1.Controls.Add(AccountTypeBox);
            panel1.Controls.Add(txtEXPdate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCardHoldName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCardNum);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhoneNum);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(50, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 681);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(239, 479);
            label13.Name = "label13";
            label13.Size = new Size(109, 20);
            label13.TabIndex = 24;
            label13.Text = "MM       /      YY";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(287, 507);
            label12.Name = "label12";
            label12.Size = new Size(17, 23);
            label12.TabIndex = 23;
            label12.Text = "/";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 505);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 27);
            textBox1.TabIndex = 22;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(220, 21);
            label11.Name = "label11";
            label11.Size = new Size(138, 31);
            label11.TabIndex = 21;
            label11.Text = "User Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.d698bd99_2fac_4c27_a443_fad2b2aaae96;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 713);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RegisterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 705);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "RegisterationForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterationForm";
            Load += RegisterationForm_Load;
            Resize += RegisterationForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtPhoneNum;
        private TextBox txtCardNum;
        private TextBox txtCardHoldName;
        private TextBox txtEXPdate;
        private TextBox txtCCV;
        private Label label9;
        private Button btnSave;
        private LinkLabel linkLabel1;
        private ComboBox AccountTypeBox;
        private Label label10;
        private Panel panel1;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label12;
        private TextBox textBox1;
        private Label label13;
    }
}