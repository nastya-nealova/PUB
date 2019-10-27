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
    class Person : INotifyPropertyChanged
    {
        public Person(string name, string surname)
        {
            FirstName = name;
            SecondName = surname;
        }

        private string first_name;
        private string second_name;

        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                if (CorrectInput(value))
                {
                    first_name = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string SecondName
        {
            get
            {
                return second_name;
            }
            set
            {
                if (CorrectInput(value))
                {
                    second_name = value;
                    OnPropertyChanged("SecondName");
                }
            }
        }

        private bool CorrectInput(string input)
        {
            if (!String.IsNullOrEmpty(input))
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
