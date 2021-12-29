using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    class Invoice : IPaymentStrategy
    {
        public void Pay()
        {
            MessageBox.Show("You are paying with Invoice!");
        }
    }
}
