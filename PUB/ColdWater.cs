
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class ColdWater
    {
        private Card info;
        public ColdWater(Card info)
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
