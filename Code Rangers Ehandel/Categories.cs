using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Rangers_Ehandel
{
    public class Categories
    {
        public string Books;
        public string Movies;
        public string Bicycles;
        public string Records;
        public string Monitors;

        public Categories(string books, string movies, string bicycles, string records, string monitors)
        {
            Books = books;
            Movies = movies;
            Bicycles = bicycles;
            Records = records;
            Monitors = monitors;
        }

        public string LoadCategories(string books, string movies, string bicycles, string records, string monitors)
        {
            MessageBox.Show(("Loading in categories..."));
            books = "books";
            movies = "movies";
            bicycles = "bicycles";
            records = "records";
            monitors = "monitors";

            return "Loading in categories..." + books + movies + bicycles + records + monitors;
        }

    }
}
