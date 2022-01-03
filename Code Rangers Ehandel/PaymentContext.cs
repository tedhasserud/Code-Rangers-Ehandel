using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Rangers_Ehandel
{
    class PaymentContext
    {
        private IPaymentStrategy PaymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.PaymentStrategy = strategy;
        }
        public void Pay()
        {
            PaymentStrategy.Pay();
        }
    }
}
