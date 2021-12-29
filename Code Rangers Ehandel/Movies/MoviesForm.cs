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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
            User.getUser();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e) //login click
        {
            Login login = new Login();
            login.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click_1(object sender, EventArgs e) // Show Cart click
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

        private void Buy1btn_Click(object sender, EventArgs e)
        {
            Movies movie1 = new Movies("Man On Fire", 10, "Thriller", "720p");
            User.getUser().BuyItem(movie1);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void Buy2btn_Click(object sender, EventArgs e)
        {
            Movies movie2 = new Movies("The Shawshank Redemption", 16, "Thriller", "4k");
            User.getUser().BuyItem(movie2);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }

        private void Buy3btn_Click(object sender, EventArgs e)
        {
            Movies movie3 = new Movies("The Town", 12, "Thriller", "720p");
            User.getUser().BuyItem(movie3);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
    }
}
