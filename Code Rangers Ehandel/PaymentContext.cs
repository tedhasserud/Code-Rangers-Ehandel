using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    class PaymentContext
    {

        public void Pay(IPaymentStrategy paymentStrategy)
        {
            paymentStrategy.Pay();
        }
    }
}
