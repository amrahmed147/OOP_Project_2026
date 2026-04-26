using System;
using System.Collections.Generic;

namespace BankProject.Classes
{
    public enum AccountType
    {
        Checking, // no3 el account (checking)
        Saving    // no3 el account (saving)
    }

    abstract public class Account
    {
        protected Client owner; // da el client beta3 el account
        public decimal Balance { get; set; } // el raseed
        public AccountType Type { get; protected set; } // no3 el account
        public List<string> history = new List<string>(); // list feha kol el operations

        public Account(Client owner, AccountType type)
        {
            this.owner = owner; // rabtna el account bel client
            Balance = 0; // awel ma yet3ml account el balance tkon 0
            Type = type; // no3 el account
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0) return false; // law rakam ghalat

            Balance += amount; // nezawed el flos
            history.Add($"Deposited: {amount} EGP on {DateTime.Now}"); // nsagel el operation
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance) return false; // law mafesh flos kfaya

            Balance -= amount; // n2alel el balance
            history.Add($"Withdrew: {amount} EGP on {DateTime.Now}"); // nsagel el operation
            return true;
        }

        public bool Transfer(Client receiver, decimal amount)
        {
            if (receiver == null || amount <= 0 || amount > Balance) return false; // validation

            Balance -= amount; // n2alel men sender
            history.Add($"Transferred: {amount} EGP to {receiver.Name} on {DateTime.Now}"); // nsagel

            receiver.Account.ReceiveTransfer(owner.Username, amount); // nb3at lel receiver
            return true;
        }

        protected void ReceiveTransfer(string senderUsername, decimal amount)
        {
            Balance += amount; // el receiver yestalem el flos
            history.Add($"Received: {amount} EGP from {senderUsername} on {DateTime.Now}"); // nsagel
        }

        public List<string> GetHistory()
        {
            return new List<string>(history); // nerga3 copy men el history
        }
    }
}