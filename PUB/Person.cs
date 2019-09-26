using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Person
    {
        private string name;
        private string surname;

        private bool CheckName(string InputName) {
            //checking input name (validation name)
            if (InputName != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckSurname(string InputSurname) {
            // validation surname
            if (InputSurname != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                if (CheckName(value))
                {
                    name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return name;
            }
            set
            {
                if (CheckName(value))
                {
                    name = value;
                }
            }
        }

        public Person(string name, string surname) {
            Name = name;
            Surname = surname;
        }

    }
}
