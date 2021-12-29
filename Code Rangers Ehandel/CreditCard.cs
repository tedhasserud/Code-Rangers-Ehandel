using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    class CreditCard : IPaymentStrategy
    {
        public void Pay()
        {
            MessageBox.Show("You are paying with your credit card!");
        }
    }
}
