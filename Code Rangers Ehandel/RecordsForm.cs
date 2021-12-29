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
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void btnBuyQ1_Click(object sender, EventArgs e)
        {
            Record queenNOTW = new Record("News of the World", 15, "records", "Rock", "Queen", "CD", 232322);
            User.getUser().BuyItem(queenNOTW);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void btnBuyQ2_Click(object sender, EventArgs e)
        {
            Record queenHS = new Record("Hot Space", 12, "records", "Rock", "Queen", "download", 299322);
            User.getUser().BuyItem(queenHS);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void btnBuyQ3_Click(object sender, EventArgs e)
        {
            Record queenAKOM = new Record("A Kind of Magic", 45, "records", "Rock", "Queen", "LP", 721322);
            User.getUser().BuyItem(queenAKOM);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
        private void show_click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
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
    }
}
