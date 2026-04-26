using BankProject.Classes;
using System.Diagnostics;

namespace BankProject
{
    public partial class LoginForm : Form
    {
        public static List<Client> clients = new List<Client>();

        public LoginForm()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
            this.AcceptButton = btnLogIn;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel1.Parent = this.pictureBox1;
            btnLogIn.BackColor = ColorTranslator.FromHtml("#f8eadf");
            button1.BackColor = ColorTranslator.FromHtml("#f8eadf");
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }
        private int ClickCounter = 0;
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            //UserForm userForm = new UserForm();    //DO NOT TOUCH
            LoginForm loginForm = new LoginForm(); //DO NOT TOUCH



            //Client foundClient = clients.FirstOrDefault(C => C.Username == txtUsername.Text && C.Password == txtPassowrd.Text);
            //searches through the clients list and returns the first item that matches the condition provided. If no item matches, it returns null.


            if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassowrd.Text))
            {

                MessageBox.Show("Please enter Username and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassowrd.Text;
            string FilePath = $"Account_{username}.txt";

            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Account Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(FilePath);
            string savedName = "";
            string savedUserName = "";
            string savedPass = "";
            string savedPhone = "";
            Card savedCard = null;
            decimal savedBalance = 0;

            foreach (string line in File.ReadAllLines(FilePath))
            {
                if (line.StartsWith("Name: ")) savedName = line.Substring("Name: ".Length);
                if (line.StartsWith("Username: ")) savedUserName = line.Substring("Username: ".Length);
                if (line.StartsWith("Password: ")) savedPass = line.Substring("Password: ".Length);
                if (line.StartsWith("Phone: ")) savedPhone = line.Substring("Phone: ".Length);
                if (line.StartsWith("Balance: ")) decimal.TryParse(line.Substring("Balance: ".Length), out savedBalance);
            }

            Client fileClient = new Client(savedName, savedUserName, savedPass, savedPhone, null, savedCard);


            if (username == savedUserName && password == savedPass)
            {
                UserForm userForm = new UserForm(fileClient);
                userForm.Show();
                this.Hide();
                txtPassowrd.Clear();
                txtUsername.Clear();
            }
            else
            {
                MessageBox.Show("Username or Password is invalid, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //else if (foundClient != null)
            //{
            //    UserForm userForm = new UserForm(foundClient);
            //    userForm.Show();


            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Username or Password is invalid, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassowrd.PasswordChar = '\0';
            }
            else
            {
                txtPassowrd.PasswordChar = '*';
            }
        }

        private void txtPassowrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterationForm registerationForm = new RegisterationForm();
            registerationForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
