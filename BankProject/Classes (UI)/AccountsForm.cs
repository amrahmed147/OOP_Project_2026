using BankProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankProject.UserForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankProject
{
    public partial class Accounts : Form
    {
        private Client client;
        private string savedName = "";
        private string savedUserName = "";
        private string savedPhone = "";
        private string AccountType = "";

        public Accounts(Client client)
        {
            InitializeComponent();
            this.client = client;
            string FilePath = $"Account_{client.Username}.txt";

            if (File.Exists(FilePath))
            {
                foreach (string line in File.ReadAllLines(FilePath))
                {
                    if (line.StartsWith("Name: ")) savedName = line.Substring("Name: ".Length);
                    if (line.StartsWith("Username: ")) savedUserName = line.Substring("Username: ".Length);
                    if (line.StartsWith("Phone Number: ")) savedPhone = line.Substring("Phone Number: ".Length);
                    if (line.StartsWith("Account Type: ")) AccountType = line.Substring("Account Type: ".Length);
                }
            }
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(client);
            userForm.ShowDialog();
        }

        private void btnCardDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardDetails cards = new CardDetails(client);
            cards.ShowDialog();
        }

        bool SliderBarExpand;
        private void SliderBar_Paint(object sender, PaintEventArgs e)
        {
            SliderBar.BackColor = ColorTranslator.FromHtml("#322f2d");
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SliderBarTimer.Start();
        }

        private void SliderBar_Tick(object sender, EventArgs e)
        {

            if (SliderBarExpand)
            {
                SliderBar.Width -= 0;

                if (SliderBar.Width == SliderBar.MinimumSize.Width)
                {
                    SliderBarExpand = false;
                    SliderBarTimer.Stop();
                }
            }
            else
            {
                SliderBar.Width += 0;
                if (SliderBar.Width == SliderBar.MaximumSize.Width)
                {
                    SliderBarExpand = true;
                    SliderBarTimer.Stop();
                }
            }
        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox.Checked)
            {

                Control parentGroup = changedCheckBox.Parent;

                foreach (Control control in parentGroup.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != changedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            lblGre.Text = $"{client.Name}'s Bank Account";

            lbName.Text = client.Name.ToString();
            lbName.Visible = true;
            lbName.Focus();

            lbluserNme.Text = client.Username.ToString();
            lbluserNme.Visible = true;
            lbluserNme.Focus();

            lblPhone.Text = savedPhone.ToString();
            lblPhone.Visible = true;
            lblPhone.Focus();

            label5.Text = AccountType;
            //lblAccountNumber.Visible = true;
            //lblAccountNumber.Focus();

            lblCurrency.Text = "EGP";

        }

        bool exitConfirmed = false;
        private void Accounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitConfirmed)
            {
                DialogResult LogOut = MessageBox.Show("Are you sure you want to exit the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (LogOut == DialogResult.Yes)
                {
                    exitConfirmed = true;
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void CardGroup_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}


