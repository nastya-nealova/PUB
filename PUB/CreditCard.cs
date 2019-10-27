using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Have Interface INotifyProperty Cnahged
using System.ComponentModel;
// CallerMemberName
using System.Runtime.CompilerServices;

namespace PUB
{
    class CreditCard : INotifyPropertyChanged
    {
        private string card_number;
        private double current_sum;

        public CreditCard(string card_number, double current_sum)
        {
            CardNumber = card_number;
            CurrentSum = current_sum;
        }


        // private set ----- need to do 
        public string CardNumber
        {
            get
            {
                return card_number;
            }
            set
            {
                if (CorrectCardNumberValue(value))
                {
                    card_number = value;
                    OnPropertyChanged("CardNumber");
                }
            }
        }
        private bool CorrectCardNumberValue(string number)
        {
            if (!String.IsNullOrEmpty(number) && number.Length == 16)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (!Char.IsDigit(number[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // private set ----- need to do 
        public double CurrentSum
        {
            get
            {
                return current_sum;
            }
            set
            {
                if (value >= 0.0)
                {
                    current_sum = value;
                    OnPropertyChanged("CurrentSum");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

