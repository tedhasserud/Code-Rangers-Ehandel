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
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
            User.getUser();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monitor xiaomi = new Monitor("Mi Curved Gaming Monitor 34", "Monitor", "Xiaomi", 500, "34", "144", true);
            User.getUser().BuyItem(xiaomi);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
    }
}