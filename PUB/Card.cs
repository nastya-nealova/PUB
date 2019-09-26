using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Card
    {
        private string cardId;
        private double cardBalance;
        public Card(string cardId, double cardBalance)
        {
            this.cardId = cardId;
            this.cardBalance = cardBalance;
        }
        public string CardId
        {
            get { return cardId; }
            set { cardId = value; }

        }
        public double CardBalance
        {
            get { return cardBalance; }
            set { cardBalance = value; }

        }
    }
    
}
