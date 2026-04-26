namespace BankProject
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            lbName = new Label();
            lbluserNme = new Label();
            lblPhone = new Label();
            lblCurrency = new Label();
            label5 = new Label();
            lblGre = new Label();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            panAccounts = new Panel();
            btnCardDetails = new Button();
            button2 = new Button();
            panCards = new Panel();
            panHome = new Panel();
            BtnHome = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SliderBar = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            panAccounts.SuspendLayout();
            panCards.SuspendLayout();
            panHome.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SliderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Enabled = true;
            SliderBarTimer.Interval = 1;
            SliderBarTimer.Tick += SliderBar_Tick;
            // 
            // lbName
            // 
            lbName.BackColor = Color.FromArgb(50, 47, 45);
            lbName.Cursor = Cursors.No;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.FromArgb(223, 211, 201);
            lbName.Location = new Point(629, 151);
            lbName.Name = "lbName";
            lbName.Size = new Size(304, 21);
            lbName.TabIndex = 17;
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbluserNme
            // 
            lbluserNme.BackColor = Color.FromArgb(50, 47, 45);
            lbluserNme.Cursor = Cursors.No;
            lbluserNme.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbluserNme.ForeColor = Color.FromArgb(223, 211, 201);
            lbluserNme.Location = new Point(629, 188);
            lbluserNme.Name = "lbluserNme";
            lbluserNme.Size = new Size(304, 22);
            lbluserNme.TabIndex = 18;
            lbluserNme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.FromArgb(50, 47, 45);
            lblPhone.Cursor = Cursors.No;
            lblPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(223, 211, 201);
            lblPhone.Location = new Point(629, 233);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(304, 21);
            lblPhone.TabIndex = 19;
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrency
            // 
            lblCurrency.BackColor = Color.FromArgb(50, 47, 45);
            lblCurrency.Cursor = Cursors.No;
            lblCurrency.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblCurrency.ForeColor = Color.FromArgb(223, 211, 201);
            lblCurrency.Location = new Point(629, 318);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(304, 23);
            lblCurrency.TabIndex = 22;
            lblCurrency.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(50, 47, 45);
            label5.Cursor = Cursors.No;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(223, 211, 201);
            label5.Location = new Point(629, 279);
            label5.Name = "label5";
            label5.Size = new Size(304, 21);
            label5.TabIndex = 24;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGre
            // 
            lblGre.AutoSize = true;
            lblGre.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            lblGre.Image = (Image)resources.GetObject("lblGre.Image");
            lblGre.ImageAlign = ContentAlignment.TopCenter;
            lblGre.Location = new Point(327, 23);
            lblGre.Name = "lblGre";
            lblGre.Size = new Size(330, 55);
            lblGre.TabIndex = 25;
            lblGre.Text = "User's Account";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1086, 553);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 97);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(143, 156);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox6);
            panel2.Location = new Point(3, 289);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 255);
            panel2.TabIndex = 27;
            // 
            // panAccounts
            // 
            panAccounts.Controls.Add(btnCardDetails);
            panAccounts.Location = new Point(3, 223);
            panAccounts.Margin = new Padding(3, 2, 3, 2);
            panAccounts.Name = "panAccounts";
            panAccounts.Size = new Size(382, 62);
            panAccounts.TabIndex = 10;
            // 
            // btnCardDetails
            // 
            btnCardDetails.FlatStyle = FlatStyle.Flat;
            btnCardDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCardDetails.ForeColor = Color.LightGray;
            btnCardDetails.Image = (Image)resources.GetObject("btnCardDetails.Image");
            btnCardDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.Location = new Point(-14, -35);
            btnCardDetails.Margin = new Padding(3, 2, 3, 2);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(26, 0, 0, 0);
            btnCardDetails.Size = new Size(267, 131);
            btnCardDetails.TabIndex = 6;
            btnCardDetails.Text = "       Card Details";
            btnCardDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.UseVisualStyleBackColor = true;
            btnCardDetails.Click += btnCardDetails_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.LightGray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-14, -19);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(26, 0, 0, 0);
            button2.Size = new Size(372, 98);
            button2.TabIndex = 7;
            button2.Text = "       Accounts";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // panCards
            // 
            panCards.Controls.Add(button2);
            panCards.Location = new Point(3, 157);
            panCards.Margin = new Padding(3, 2, 3, 2);
            panCards.Name = "panCards";
            panCards.Size = new Size(343, 62);
            panCards.TabIndex = 9;
            // 
            // panHome
            // 
            panHome.Controls.Add(BtnHome);
            panHome.Location = new Point(3, 84);
            panHome.Margin = new Padding(3, 2, 3, 2);
            panHome.Name = "panHome";
            panHome.Size = new Size(304, 69);
            panHome.TabIndex = 8;
            // 
            // BtnHome
            // 
            BtnHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BtnHome.ForeColor = Color.LightGray;
            BtnHome.Image = (Image)resources.GetObject("BtnHome.Image");
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(-14, -6);
            BtnHome.Margin = new Padding(3, 2, 3, 2);
            BtnHome.Name = "BtnHome";
            BtnHome.Padding = new Padding(26, 0, 0, 0);
            BtnHome.Size = new Size(298, 94);
            BtnHome.TabIndex = 5;
            BtnHome.Text = "       Home";
            BtnHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 78);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            // 
            // SliderBar
            // 
            SliderBar.BackColor = Color.Gray;
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
            SliderBar.TabIndex = 1;
            SliderBar.Paint += SliderBar_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(327, 140);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 201);
            ClientSize = new Size(1082, 546);
            Controls.Add(pictureBox2);
            Controls.Add(lblGre);
            Controls.Add(label5);
            Controls.Add(lblCurrency);
            Controls.Add(lblPhone);
            Controls.Add(lbluserNme);
            Controls.Add(lbName);
            Controls.Add(SliderBar);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounts";
            FormClosing += Accounts_FormClosing;
            Load += Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panAccounts.ResumeLayout(false);
            panCards.ResumeLayout(false);
            panHome.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SliderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer SliderBarTimer;
        private Label lblName;
        private Label LblBalance;
        private Label lblAccountType;
        private Label label6;
        private Label lbName;
        private Label lbluserNme;
        private Label lblPhone;
        private Label label10;
        private Label lblCurrency;
        private Label label5;
        private Label lblGre;
        private PictureBox pictureBox3;
        private PictureBox MenuBtn;
        private PictureBox pictureBox6;
        private Panel panel2;
        private Panel panAccounts;
        private Button button2;
        private Panel panCards;
        private Button btnCardDetails;
        private Panel panHome;
        private Button BtnHome;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel SliderBar;
        private PictureBox pictureBox2;
    }
}