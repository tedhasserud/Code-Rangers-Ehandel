using Code_Rangers_Ehandel.Bicycles;
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
       

        public Form1(Categories categories, Images images, Lights lights, User user)
        {
            InitializeComponent();
            everythingFacade = new EverythingFacade(categories, images, lights, user);
            MessageBox.Show(everythingFacade.StartApp("Ted"));
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
            
        }

        private void Books_click(object sender, EventArgs e)
        {
            BooksForm BooksForm = new BooksForm();
            BooksForm.Show();
        }
        private void showcart_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RecordsForm RecordsForm = new RecordsForm();
            RecordsForm.Show();
        }

        private void Bicycles_Click(object sender, EventArgs e)
        {
            BicycleForm BicycleForm = new BicycleForm();
            BicycleForm.Show();
        }
        private void label4_Click(object sender, EventArgs e) // movies
        {
            MoviesForm MoviesForm = new MoviesForm();
            MoviesForm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(everythingFacade.CloseApp("Ted"));
        }
    }
}
