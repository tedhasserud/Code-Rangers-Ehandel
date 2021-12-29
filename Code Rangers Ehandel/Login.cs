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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_click(object sender, EventArgs e)
        {
            User.getInstance(usernameTxt.Text, pwTxt.Text);
        }
    }
}
