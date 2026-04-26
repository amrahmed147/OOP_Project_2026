using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                
                string Name = txtName.Text;
                string PhoneNumber = txtPhoneNum.Text;
                string AccountType = AccountTypeBox.Text;
                string CardNum = txtCardNum.Text;
                string CardHolderName = txtCardHoldName.Text;
                string ExpDateY = txtEXPdate.Text;
                string ExpDateM = textBox1.Text;
                string CCV = txtCCV.Text;
                int CCVN = Convert.ToInt32(CCV);


                string FilePath = $"Account_{Username}.txt";
                string FilePathCard = $"Card_{Username}.txt";

                if (File.Exists(FilePath) || File.Exists(FilePathCard))
                {
                    MessageBox.Show("Username already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsCardNumberUsed(CardNum))
                {
                    MessageBox.Show("Card Number already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsPhoneNumberUsed(PhoneNumber))
                {
                    MessageBox.Show("Phone Number already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsUsernameUsed(Username))
                {
                    MessageBox.Show("Username already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidCardNumber(txtCardNum.Text))
                {
                    MessageBox.Show("Invalid card number. Please check the format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Password.Length < 10 || !Password.Any(char.IsLetter) || !Password.Any(char.IsDigit))
                {
                    MessageBox.Show("Password must be at least 10 characters long and contain both letters and numbers.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (PhoneNumber.Length < 11 )
                {
                    MessageBox.Show("Invalid Phone Number", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string data = $"Username: {Username}\n" +
                             $"Password: {Password}\n" +
                             $"Name: {Name}\n" +
                             $"Phone Number: {PhoneNumber}\n" +
                             $"Account Type: {AccountType}\n";

                string dataCard = $"Card Number: {CardNum}\n" +
                                $"Card Holder Name: {CardHolderName}\n" +
                                $"Expiration Date: {ExpDateY} / {ExpDateM}\n" +
                                $"CCV: {CCV}";

                File.WriteAllText(FilePath, data);
                File.WriteAllText(FilePathCard, dataCard);

                MessageBox.Show("Account created successfully!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error occured, try again please");
            }



        }

        private void RegisterationForm_Load(object sender, EventArgs e)
        {
            this.panel1.Parent = this.pictureBox1;
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool IsPhoneNumberUsed(string phoneNumber)
        {
            string[] FilesOfAccounts = Directory.GetFiles(".", "Account_*.txt");
            foreach (var file in FilesOfAccounts)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(phoneNumber))
                    return true;
            }
            return false;
        }
        private bool IsValidCardNumber(string cardNumber)
        {
            // Remove hyphens
            string digitsOnly = cardNumber.Replace("-", "");


            if (digitsOnly.Length != 16 || !digitsOnly.All(char.IsDigit))
                return false;


            if (!System.Text.RegularExpressions.Regex.IsMatch(cardNumber, @"^\d{4}-\d{4}-\d{4}-\d{4}$"))
                return false;

            return true;
        }

        bool IsCardNumberUsed(string cardNumber)
        {
            string[] cardFiles = Directory.GetFiles(".", "Card_*.txt");
            foreach (var file in cardFiles)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(cardNumber)) return true;

            }
            return false;
        }
        bool IsUsernameUsed(string username)
        {
            string[] FilesOfAccounts = Directory.GetFiles(".", "Account_*.txt");
            foreach (var file in FilesOfAccounts)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(username))
                    return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtEXPdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }



        }

        private void txtCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {

                int pos = txtCardNum.SelectionStart;
                txtCardNum.Text = txtCardNum.Text.Insert(pos, "-");
                txtCardNum.SelectionStart = pos + 1;
                e.Handled = true;
                return;
            }


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCardHoldName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
                return;


            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtCCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void RegisterationForm_Resize(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
