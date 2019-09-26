using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    enum ServicesIdentificator {
        HotWater=1,
        ColdWater,
        Gas,
        ElectricPower,
        Heating
    }
    class Receipt
    {
        private ServicesIdentificator Services;
    }
}
