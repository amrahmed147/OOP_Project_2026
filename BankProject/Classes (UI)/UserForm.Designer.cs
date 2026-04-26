namespace BankProject
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            slidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            panel3 = new Panel();
            btnHome = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            btnCardDetails = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            btnLogOut = new Button();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnWithdrawl = new Button();
            txtCurrentBalance = new TextBox();
            ListBoxTransactionHis = new ListBox();
            lblCurrentBalance = new Label();
            lblGreetings = new Label();
            pictureBox3 = new PictureBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            slidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // slidebar
            // 
            slidebar.BackColor = SystemColors.AppWorkspace;
            slidebar.Controls.Add(panel1);
            slidebar.Controls.Add(panel3);
            slidebar.Controls.Add(panel5);
            slidebar.Controls.Add(panel6);
            slidebar.Controls.Add(panel7);
            slidebar.Controls.Add(panel8);
            slidebar.Controls.Add(panel10);
            slidebar.Controls.Add(panel4);
            slidebar.Dock = DockStyle.Left;
            slidebar.Location = new Point(0, 0);
            slidebar.Margin = new Padding(3, 2, 3, 2);
            slidebar.MaximumSize = new Size(243, 544);
            slidebar.MinimumSize = new Size(73, 544);
            slidebar.Name = "slidebar";
            slidebar.Size = new Size(177, 544);
            slidebar.TabIndex = 1;
            slidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 63);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // MenuBtn
            // 
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(9, 16);
            MenuBtn.Margin = new Padding(3, 2, 3, 2);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(51, 39);
            MenuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHome);
            panel3.Location = new Point(3, 69);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 45);
            panel3.TabIndex = 5;
            // 
            // btnHome
            // 
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-9, -10);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(26, 0, 0, 0);
            btnHome.Size = new Size(259, 63);
            btnHome.TabIndex = 4;
            btnHome.Text = "         Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += button2_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 118);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 45);
            panel5.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-9, -10);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(26, 0, 0, 0);
            button4.Size = new Size(259, 63);
            button4.TabIndex = 4;
            button4.Text = "         Accounts ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCardDetails);
            panel6.Location = new Point(3, 167);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(241, 45);
            panel6.TabIndex = 8;
            // 
            // btnCardDetails
            // 
            btnCardDetails.FlatStyle = FlatStyle.Flat;
            btnCardDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardDetails.ForeColor = SystemColors.ButtonHighlight;
            btnCardDetails.Image = (Image)resources.GetObject("btnCardDetails.Image");
            btnCardDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.Location = new Point(-9, -10);
            btnCardDetails.Margin = new Padding(3, 2, 3, 2);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(26, 0, 0, 0);
            btnCardDetails.Size = new Size(259, 63);
            btnCardDetails.TabIndex = 4;
            btnCardDetails.Text = "         Card Details";
            btnCardDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.UseVisualStyleBackColor = true;
            btnCardDetails.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 216);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(241, 45);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Location = new Point(3, 265);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(241, 45);
            panel8.TabIndex = 10;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnLogOut);
            panel10.Location = new Point(3, 314);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(241, 45);
            panel10.TabIndex = 5;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(-9, -10);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(26, 0, 0, 0);
            btnLogOut.Size = new Size(259, 63);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "         Log out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox6);
            panel4.Location = new Point(3, 363);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 181);
            panel4.TabIndex = 10;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 23);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(143, 156);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Interval = 1;
            SliderBarTimer.Tick += SliderBar_Tick;
            // 
            // btnDeposit
            // 
            btnDeposit.FlatStyle = FlatStyle.Popup;
            btnDeposit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.ForeColor = Color.Linen;
            btnDeposit.Image = (Image)resources.GetObject("btnDeposit.Image");
            btnDeposit.Location = new Point(215, 371);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(104, 43);
            btnDeposit.TabIndex = 6;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.FlatStyle = FlatStyle.Popup;
            btnTransfer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Image = (Image)resources.GetObject("btnTransfer.Image");
            btnTransfer.Location = new Point(341, 371);
            btnTransfer.Margin = new Padding(3, 2, 3, 2);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(113, 43);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnWithdrawl
            // 
            btnWithdrawl.FlatStyle = FlatStyle.Popup;
            btnWithdrawl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrawl.ForeColor = Color.Linen;
            btnWithdrawl.Image = (Image)resources.GetObject("btnWithdrawl.Image");
            btnWithdrawl.Location = new Point(484, 371);
            btnWithdrawl.Margin = new Padding(3, 2, 3, 2);
            btnWithdrawl.Name = "btnWithdrawl";
            btnWithdrawl.Size = new Size(121, 43);
            btnWithdrawl.TabIndex = 9;
            btnWithdrawl.Text = "Withdraw";
            btnWithdrawl.UseVisualStyleBackColor = true;
            btnWithdrawl.Click += btnWithdrawl_Click;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.BackColor = SystemColors.AppWorkspace;
            txtCurrentBalance.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentBalance.Cursor = Cursors.IBeam;
            txtCurrentBalance.Font = new Font("Simplified Arabic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentBalance.Location = new Point(215, 304);
            txtCurrentBalance.Margin = new Padding(3, 2, 3, 2);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(390, 47);
            txtCurrentBalance.TabIndex = 10;
            txtCurrentBalance.TextAlign = HorizontalAlignment.Center;
            txtCurrentBalance.TextChanged += txtCurrentBalance_TextChanged_1;
            txtCurrentBalance.Enter += txtCurrentBalance_Enter;
            // 
            // ListBoxTransactionHis
            // 
            ListBoxTransactionHis.BackColor = Color.FromArgb(50, 47, 45);
            ListBoxTransactionHis.BorderStyle = BorderStyle.None;
            ListBoxTransactionHis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ListBoxTransactionHis.ForeColor = SystemColors.AppWorkspace;
            ListBoxTransactionHis.FormattingEnabled = true;
            ListBoxTransactionHis.ItemHeight = 21;
            ListBoxTransactionHis.Location = new Point(669, 108);
            ListBoxTransactionHis.Margin = new Padding(3, 2, 3, 2);
            ListBoxTransactionHis.Name = "ListBoxTransactionHis";
            ListBoxTransactionHis.Size = new Size(348, 336);
            ListBoxTransactionHis.TabIndex = 11;
            ListBoxTransactionHis.SelectedIndexChanged += ListBoxTransactionHis_SelectedIndexChanged_1;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.BackColor = Color.FromArgb(50, 47, 45);
            lblCurrentBalance.Font = new Font("Georgia", 34F, FontStyle.Bold);
            lblCurrentBalance.ForeColor = SystemColors.AppWorkspace;
            lblCurrentBalance.Location = new Point(255, 165);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(199, 80);
            lblCurrentBalance.TabIndex = 34;
            lblCurrentBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreetings.Image = (Image)resources.GetObject("lblGreetings.Image");
            lblGreetings.Location = new Point(215, 39);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(348, 55);
            lblGreetings.TabIndex = 14;
            lblGreetings.Text = "Greetings, user!";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1085, 544);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(50, 47, 45);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            listBox1.ForeColor = Color.FromArgb(50, 47, 45);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(215, 116);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(390, 168);
            listBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(50, 47, 45);
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(209, 116);
            label2.Name = "label2";
            label2.Size = new Size(0, 55);
            label2.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(50, 47, 45);
            label3.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(215, 116);
            label3.Name = "label3";
            label3.Size = new Size(289, 40);
            label3.TabIndex = 32;
            label3.Text = "Current Balance: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(50, 47, 45);
            label4.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(441, 177);
            label4.Name = "label4";
            label4.Size = new Size(122, 55);
            label4.TabIndex = 33;
            label4.Text = "EGP";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1082, 546);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblGreetings);
            Controls.Add(lblCurrentBalance);
            Controls.Add(ListBoxTransactionHis);
            Controls.Add(txtCurrentBalance);
            Controls.Add(btnWithdrawl);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(slidebar);
            Controls.Add(listBox1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "UserForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            FormClosing += UserForm_FormClosing;
            Load += UserForm_Load;
            slidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel slidebar;
        private Panel panel1;
        private Button btnCardDetails;
        private Panel panel3;
        private Button btnHome;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Button btnLogOut;
        private PictureBox MenuBtn;
        private System.Windows.Forms.Timer SliderBarTimer;
        private Button btnDeposit;
        private Button btnTransfer;
        private Button btnWithdrawl;
        private TextBox txtCurrentBalance;
        private ListBox ListBoxTransactionHis;
        private Label lblCurrentBalance;
        private Label lblGreetings;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox6;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}