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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_click(object sender, EventArgs e)
        {
            User.getInstance(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }
    }
}
