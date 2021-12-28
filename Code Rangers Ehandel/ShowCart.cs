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
    public partial class ShowCart : Form
    {
        CartBuilder cartBuilder;
        ShoppingCart cart;
        public ShowCart()
        {
            InitializeComponent();
            //cartBuilder = new CartBuilder();
            //listBox1.Items.Add(CartBuilder.Cart());
            //User.getUser();
            //cart = new ShoppingCart(); 
            listBox1.Items.Add(User.getUser().showItems());

        }
    }
}
