﻿using System;
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
        ShoppingCart cart;
        CartBuilder cartBuilder;
        public BooksForm()
        {
            InitializeComponent();
            cart = new ShoppingCart();
            cartBuilder = new CartBuilder();
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

        public void book2_Click(object sender, EventArgs e)
        {
            Book lotr2 = new Book("The Two Towers", 12, "Book", "Fantasy", "Hardcover", "JRR Tolkien", "9780261102361");
            //cart.AddItem(lotr2);
            User.getUser().BuyItem(lotr2);
            MessageBox.Show("In your cart is: " + User.getUser().showItems().ToString());

        }

        public void book3_Click(object sender, EventArgs e)
        {
            Book lotr3 = new Book("The Return of the King", 12, "Book", "Fantasy", "Hardcover", "JRR Tolkien", "9780261102378");
            //cart.AddItem(lotr3);
            User.getUser().BuyItem(lotr3);
            MessageBox.Show("In your cart is: " + User.getUser().showItems().ToString());
        }

        private void book1_Click(object sender, EventArgs e)
        {
            Book lotr1 = new Book("The Fellowship of the Ring", 12, "Book", "Fantasy", "Hardcover", "JRR Tolkien", "9780261103573");
            //cart.AddItem(lotr1);
            User.getUser().BuyItem(lotr1);
            MessageBox.Show("In your cart is: " + User.getUser().showItems().ToString());
        }

        private void show_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart(); 
            showCart.Show();
        }
    }
}
