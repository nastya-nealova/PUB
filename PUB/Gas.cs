using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Gas
    {
        private Card info;
        public Gas(Card info)
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
