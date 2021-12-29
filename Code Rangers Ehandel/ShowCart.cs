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
        public ShowCart()
        {
            InitializeComponent();

            foreach (var item in User.getUser().ActiveCart)
            {
                listBox1.Items.Add(item.Name);
            }
        }
        private void ok_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        public void RemoveItem()
        {
            var selectedItem = listBox1.SelectedItem.ToString();

            foreach (var item in User.getUser().ActiveCart)
            {
                if (item.Name.Contains(selectedItem))
                {
                    User.getUser().ActiveCart.Remove(item);
                    listBox1.Items.Remove(selectedItem);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckoutForm checkOut = new CheckoutForm();
            checkOut.Show();
        }
    }

      
}
