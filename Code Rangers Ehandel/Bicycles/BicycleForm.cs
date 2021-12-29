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

#region Not Used
        private void BicycleForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void buyBikeOne_Click(object sender, EventArgs e)
        {
            Bicycle bike1 = new Bicycle("Skeppshult Natur", 890, "Bicycle");
            User.getUser().BuyItem(bike1);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void buyBikeTwo_Click(object sender, EventArgs e)
        {
            Bicycle bike2 = new Bicycle("Skeppshult Colour", 960, "Bicycle");
            User.getUser().BuyItem(bike2);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void buyBikeThree_Click(object sender, EventArgs e)
        {
            Bicycle bike3 = new Bicycle("Skeppshult Elit", 1120, "Bicycle");
            User.getUser().BuyItem(bike3);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }
    }
}
