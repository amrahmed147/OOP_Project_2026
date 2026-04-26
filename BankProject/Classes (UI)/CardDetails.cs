using BankProject.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static BankProject.UserForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankProject
{

    public partial class CardDetails : Form
    {
        private Client client;

        string savedCardNum = null;
        string savedCardName = null;
        int savedCCV = 0;
        string ExpDate = null;
        public CardDetails(Client client)
        {
            InitializeComponent();
            this.client = client;
            string FilePathCard = $"Card_{client.Username}.txt";



            if (File.Exists(FilePathCard))
            {
                foreach (string line in File.ReadAllLines(FilePathCard))
                {
                    if (line.StartsWith("Card Number: ")) savedCardNum = line.Substring("Card Number: ".Length);
                    if (line.StartsWith("Card Holder Name: ")) savedCardName = line.Substring("Card Holder Name: ".Length);
                    if (line.StartsWith("Expiration Date: ")) ExpDate = line.Substring("Expiration Date: ".Length);
                    if (line.StartsWith("CCV: "))
                    {
                        int tempCCV;
                        if (int.TryParse(line.Substring("CCV: ".Length), out tempCCV))
                            savedCCV = tempCCV;
                    }
                }

            }
        }

        private void CardDetails_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
        }



        private void SliderBar_Tick(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(client);
            userForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#322f2d");
            ForeColor = ColorTranslator.FromHtml("#dfd3c9");
            try
            {
                string password = client.Password;
                string UserInput = Interaction.InputBox("Enter your password", "Password confirmation", "", -1, -1);

                if (string.IsNullOrEmpty(UserInput))
                {
                    MessageBox.Show("Please enter a password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (UserInput == password)
                {
                    lblCardNumber.Text = savedCardNum;
                    lblDate.Text = ExpDate;
                    lblCVV.Text = savedCCV.ToString();
                    lblName.Text = savedCardName;

                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                }
                else
                {
                    CustomMessageBox msg = new CustomMessageBox();
                    msg.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Error occured, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts accountsForm = new Accounts(client);
            accountsForm.ShowDialog();
        }
        private void CardDetails_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        bool exitConfirmed = false;

        private void CardDetails_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCVV_Click(object sender, EventArgs e)
        {

        }

        private void btnCardDetails_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        
    }
    }

