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
    class Address : INotifyPropertyChanged
    {
        private string street;
        private int house;
        private int flat;

        public Address(string street, int house, int flat)
        {
            Street = street;
            House = house;
            Flat = flat;
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    street = value;
                    OnPropertyChanged("Street");
                }
            }
        }

        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (CheckCorrectNumber(value))
                {
                    house = value;
                    OnPropertyChanged("House");
                }
            }
        }

        public int Flat
        {
            get
            {
                return flat;
            }
            set
            {
                if (CheckCorrectNumber(value))
                {
                    flat = value;
                    OnPropertyChanged("Flat");
                }
            }
        }

        private bool CheckCorrectNumber(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
