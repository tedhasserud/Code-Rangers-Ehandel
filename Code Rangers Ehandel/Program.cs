using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Categories categories = new Categories("books", "movies", "bicycles", "records", "monitors");
            Images images = new Images();
            Lights lights = new Lights();
            User user = new User("Ted");
            Application.Run(new Form1(categories, images, lights, user));
        }
    }
}
