using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUB
{
    class CreditOperations
    {
        static public void Put(double Sum, CreditCard DestinationCard)
        {
            DestinationCard.CurrentSum = DestinationCard.CurrentSum + Sum;
        }

        static public bool Withdraw(double Sum, CreditCard SourceCard)
        {
            if (SourceCard.CurrentSum >= Sum)
            {
                SourceCard.CurrentSum = SourceCard.CurrentSum - Sum;
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool Transfer(double Sum, CreditCard SourceCard, CreditCard DestinationCard)
        {
            if (Withdraw(Sum, SourceCard))
            {
                Put(Sum, DestinationCard);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
