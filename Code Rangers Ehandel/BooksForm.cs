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
        Book lotr1 = new Book("The Fellowship of the Ring", 12, "Book", "Fantasy", "Hardcover", "JRR Tolkien", "9780261103573");
        Book lotr2 = new Book("The Two Towers", 12, "Book", "Fantasy", "Hardcover", "JRR Tolkien", "9780261102361");
        Book lotr3 = new Book("The Return of the King", 12, "Book", "Fantasy", "Hardcover", "JRR Tolkien", "9780261102378");

        public BooksForm()
        {
            InitializeComponent();
            User.getUser();
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
        private void book1_Click(object sender, EventArgs e)
        {
            User.getUser().BuyItem(lotr1);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
        public void book2_Click(object sender, EventArgs e)
        {
            User.getUser().BuyItem(lotr2);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
        public void book3_Click(object sender, EventArgs e)
        {
            User.getUser().BuyItem(lotr3);
            MessageBox.Show("In your cart is: " + User.getUser().ShowItems());
        }
        private void show_click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1,lotr1.Name); 
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox2, lotr2.Name);

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(pictureBox3, lotr3.Name);

        }
    }
}
