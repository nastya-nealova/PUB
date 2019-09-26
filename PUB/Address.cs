using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Address
    {
        private string street;
        private int house;
        private int flat;

        public Address(string street,int house,int flat)
        {
            this.street = street;
            this.house = house;
            this.flat = flat;
        }
        public string Street
        {
            get { return street; }
            set { street = value; }

        }
        public int House
        {
            get { return house; }
            set { house = value; }

        }
        public int Flat
        {
            get { return flat; }
            set { flat = value; }

        }
    }
   
}
