using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    public class Client
    {
        public string Name { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string PhoneNum { get; private set; }
        public Account Account { get;  private set; }
        public Client(string Name, string Username, string Password,string PhoneNum , Account Account, Card card)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.PhoneNum = PhoneNum;
            string typeString = "Saving"; 
            AccountType type = (AccountType)Enum.Parse(typeof(AccountType), typeString);

            if (type == AccountType.Checking)
                this.Account = new CheckingAccount(this);
            else
                this.Account = new SavingAccount(this, 0.05m);
        }
        public void SetAccount(Account account)
        {
            Account = account;
        }
        public bool Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            return Username == username && Password == password;
        }
    }
}