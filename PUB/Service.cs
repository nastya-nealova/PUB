using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class Service
    {
        private CreditCard credit_card;
        private Address address;
        private string service_name;

        public string ServiceName
        {
            get
            {
                return service_name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    service_name = value;
                }
            }
        }


    }
}
