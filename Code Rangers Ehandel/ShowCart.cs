using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    public partial class ShowCart : Form
    {
        public ShowCart()
        {
            InitializeComponent();

            foreach (var item in User.getUser().ActiveCart)
            {
                listBox1.Items.Add(item.Name);
            }
        }
        private void ok_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
