using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    public class EverythingFacade
    {
        public Categories Categories;
        public Images Images;
        public Lights Lights;
        public User User;

        public EverythingFacade(Categories categories, Images images, Lights lights, User user)
        {
            Categories = categories;
            Images = images;
            Lights = lights;
            User = user;
        }

        public string StartApp(string user)
        {
            MessageBox.Show(("Adjusting all settings.."));
            Categories.LoadCategories("books", "movies", "bicycles", "records", "monitors");
            Images.Load();
            Lights.On();
            User.getUser(user);            
            return "Welcome to eVerything " + user + "!";
        }

        public string CloseApp(string user)
        {
            MessageBox.Show(("Shutting down service..."));
            Lights.Off();
            return "Thanks for using eVerything " + user + "!";
        }
    }
}
