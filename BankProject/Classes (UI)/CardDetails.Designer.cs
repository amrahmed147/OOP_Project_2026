namespace BankProject
{
    partial class CardDetails
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDetails));
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            lblCardNumber = new Label();
            lblDate = new Label();
            lblName = new Label();
            lblCVV = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            btnCardDetails = new Button();
            BtnHome = new Button();
            SliderBar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            panHome = new Panel();
            panCards = new Panel();
            panAccounts = new Panel();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            lblGre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SliderBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panHome.SuspendLayout();
            panCards.SuspendLayout();
            panAccounts.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Enabled = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 47, 45);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(223, 211, 201);
            button3.Location = new Point(433, 468);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(374, 52);
            button3.TabIndex = 1;
            button3.Text = "Reveal Card information";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // lblCardNumber
            // 
            lblCardNumber.BackColor = Color.Black;
            lblCardNumber.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardNumber.ForeColor = Color.White;
            lblCardNumber.Location = new Point(755, 212);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(245, 27);
            lblCardNumber.TabIndex = 3;
            lblCardNumber.Text = "      6574   2039    4309    5674";
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Black;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(941, 253);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 26);
            lblDate.TabIndex = 4;
            lblDate.Text = "01/26";
            lblDate.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Black;
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(668, 286);
            lblName.Name = "lblName";
            lblName.Size = new Size(233, 31);
            lblName.TabIndex = 5;
            lblName.Text = "   Name +Surname";
            lblName.Click += lblName_Click;
            // 
            // lblCVV
            // 
            lblCVV.BackColor = Color.White;
            lblCVV.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCVV.ForeColor = SystemColors.ActiveCaptionText;
            lblCVV.Location = new Point(513, 207);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(57, 32);
            lblCVV.TabIndex = 6;
            lblCVV.Text = "598";
            lblCVV.Click += lblCVV_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(755, 209);
            label2.Name = "label2";
            label2.Size = new Size(245, 30);
            label2.TabIndex = 7;
            label2.Text = "********************************************************************************************************************";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(941, 253);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 8;
            label3.Text = "****";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(668, 286);
            label4.Name = "label4";
            label4.Size = new Size(233, 31);
            label4.TabIndex = 9;
            label4.Text = "************************************************************************************";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(513, 207);
            label5.Name = "label5";
            label5.Size = new Size(57, 33);
            label5.TabIndex = 10;
            label5.Text = "***********************************";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -28);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 585);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(659, 129);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(392, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(196, 129);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(392, 218);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-12, -20);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(26, 0, 0, 0);
            button2.Size = new Size(199, 83);
            button2.TabIndex = 4;
            button2.Text = "       Accounts";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCardDetails
            // 
            btnCardDetails.FlatStyle = FlatStyle.Flat;
            btnCardDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCardDetails.ForeColor = Color.White;
            btnCardDetails.Image = (Image)resources.GetObject("btnCardDetails.Image");
            btnCardDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.Location = new Point(-12, -15);
            btnCardDetails.Margin = new Padding(3, 2, 3, 2);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(26, 0, 0, 0);
            btnCardDetails.Size = new Size(259, 80);
            btnCardDetails.TabIndex = 5;
            btnCardDetails.Text = "       Card Details";
            btnCardDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.UseVisualStyleBackColor = true;
            btnCardDetails.Click += btnCardDetails_Click;
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.FromArgb(50, 47, 45);
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BtnHome.ForeColor = Color.White;
            BtnHome.Image = (Image)resources.GetObject("BtnHome.Image");
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(-12, -14);
            BtnHome.Margin = new Padding(3, 2, 3, 2);
            BtnHome.Name = "BtnHome";
            BtnHome.Padding = new Padding(26, 0, 0, 0);
            BtnHome.Size = new Size(199, 92);
            BtnHome.TabIndex = 2;
            BtnHome.Text = "         Home";
            BtnHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += MenuBtn_Click;
            // 
            // SliderBar
            // 
            SliderBar.BackColor = Color.FromArgb(50, 47, 45);
            SliderBar.Controls.Add(panel1);
            SliderBar.Controls.Add(panHome);
            SliderBar.Controls.Add(panCards);
            SliderBar.Controls.Add(panAccounts);
            SliderBar.Controls.Add(panel2);
            SliderBar.Dock = DockStyle.Left;
            SliderBar.Location = new Point(0, 0);
            SliderBar.Margin = new Padding(3, 2, 3, 2);
            SliderBar.MaximumSize = new Size(243, 544);
            SliderBar.MinimumSize = new Size(73, 544);
            SliderBar.Name = "SliderBar";
            SliderBar.Size = new Size(170, 544);
            SliderBar.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 98);
            panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 26);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            // 
            // panHome
            // 
            panHome.Controls.Add(BtnHome);
            panHome.Location = new Point(3, 104);
            panHome.Margin = new Padding(3, 2, 3, 2);
            panHome.Name = "panHome";
            panHome.Size = new Size(304, 69);
            panHome.TabIndex = 8;
            // 
            // panCards
            // 
            panCards.Controls.Add(button2);
            panCards.Location = new Point(3, 177);
            panCards.Margin = new Padding(3, 2, 3, 2);
            panCards.Name = "panCards";
            panCards.Size = new Size(343, 62);
            panCards.TabIndex = 9;
            // 
            // panAccounts
            // 
            panAccounts.Controls.Add(btnCardDetails);
            panAccounts.Location = new Point(3, 243);
            panAccounts.Margin = new Padding(3, 2, 3, 2);
            panAccounts.Name = "panAccounts";
            panAccounts.Size = new Size(382, 62);
            panAccounts.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox6);
            panel2.Location = new Point(3, 309);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 240);
            panel2.TabIndex = 27;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 79);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(143, 156);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // lblGre
            // 
            lblGre.AutoSize = true;
            lblGre.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            lblGre.ForeColor = SystemColors.ActiveCaptionText;
            lblGre.Image = (Image)resources.GetObject("lblGre.Image");
            lblGre.ImageAlign = ContentAlignment.TopCenter;
            lblGre.Location = new Point(196, 28);
            lblGre.Name = "lblGre";
            lblGre.Size = new Size(275, 55);
            lblGre.TabIndex = 26;
            lblGre.Text = "Credit Card";
            // 
            // CardDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 201);
            ClientSize = new Size(1082, 546);
            Controls.Add(lblGre);
            Controls.Add(SliderBar);
            Controls.Add(label5);
            Controls.Add(lblCVV);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblDate);
            Controls.Add(lblCardNumber);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CardDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CardDetails";
            FormClosing += CardDetails_FormClosing;
            FormClosed += CardDetails_FormClosed;
            Load += CardDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            SliderBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panHome.ResumeLayout(false);
            panCards.ResumeLayout(false);
            panAccounts.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel SliderBar;
        private Panel panMenu;
        private System.Windows.Forms.Timer SliderBarTimer;
        private Button button3;
        private Label lblCardNumber;
        private Label lblDate;
        private Label lblName;
        private Label lblCVV;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private Button btnCardDetails;
        private Button BtnHome;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label1;
        private Panel panHome;
        private Panel panCards;
        private Panel panAccounts;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Label lblGre;
    }
}