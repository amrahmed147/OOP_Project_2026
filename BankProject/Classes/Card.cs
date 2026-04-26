using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    public class Card
    {
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CVV { get; set; }
        public Card(string cardNumber, DateTime expirationDate, string cvv)
        {
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            CVV = cvv;
        }
        public static Card c1 = new Card("2598-5678-2571-8296", new DateTime(2025, 12, 31), "352");
        public static Card c2 = new Card("3937-5432-1945-7262", new DateTime(2024, 11, 30), "456");
    }
}
