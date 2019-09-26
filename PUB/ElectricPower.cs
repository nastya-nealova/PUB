using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class ElectricPower
    {
        private Card info;
        public ElectricPower(Card info)
        {
            this.info = info;
        }
        public Card Info
        {
            get { return info; }
            set { info = value; }
        }
    }
}
