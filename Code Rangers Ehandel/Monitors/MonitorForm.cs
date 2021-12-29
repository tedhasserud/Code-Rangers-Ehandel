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
        private void monitor1_Click(object sender, EventArgs e)
        {
            Monitor xiaomi = new Monitor("Mi Curved Gaming Monitor", "Monitor", "Xiaomi", 500, "34", "144", true);
            User.getUser().BuyItem(xiaomi);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
        private void monitor2_Click(object sender, EventArgs e)
        {
            Monitor lg = new Monitor("UltraGear 38GN950", "Monitor", "LG", 1200, "38", "160", true);
            User.getUser().BuyItem(lg);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void monitor3_Click(object sender, EventArgs e)
        {
            Monitor samsung = new Monitor("Samsung Odyssey C32G55", "Monitor", "Samsung", 1200, "32", "144", true);
            User.getUser().BuyItem(samsung);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
        private void show_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

    }
}