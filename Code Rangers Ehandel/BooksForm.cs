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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void register_click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void home_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
