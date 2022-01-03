using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    public class Lights
    {
        public Lights()
        {

        }

        public void On()
        {
            MessageBox.Show(("Turning on background lights..."));
        }

        public void Off()
        {
            MessageBox.Show(("Turning off lights..."));
        }
    }
}
