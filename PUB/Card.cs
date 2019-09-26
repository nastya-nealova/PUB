using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Card
    {
        private string id;
        private double cardBalance;
        public Card(string id, double cardBalance)
        {
            this.id = id;
            this.cardBalance = cardBalance;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }

        }
        public double CardBalance
        {
            get { return cardBalance; }
            set { cardBalance = value; }

        }
    }
    
}
