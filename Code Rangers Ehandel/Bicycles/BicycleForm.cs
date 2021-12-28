using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel.Bicycles
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
