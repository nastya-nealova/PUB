using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Heating
    {
        private Card info;
        public Heating(Card info)
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
