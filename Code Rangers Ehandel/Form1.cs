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
    public partial class Form1 : Form
    {
        EverythingFacade everythingFacade;
        Categories categories;
        Images images;
        Lights lights;
        User user;

        public Form1()
        {
            InitializeComponent();
            everythingFacade = new EverythingFacade(categories, images, lights, user);
        }

        private void login(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            MessageBox.Show(everythingFacade.StartApp("Ted"));
        }

        private void Books_click(object sender, EventArgs e)
        {
            BooksForm BooksForm = new BooksForm();
            BooksForm.Show();

        }
    }
}
