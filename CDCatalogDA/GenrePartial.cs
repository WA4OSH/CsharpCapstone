using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDCatalogEF;

namespace CDCatalogDA
{
    public partial class Genre
    {
        public static List<CDCatalogEF.Genre> GetAllGenres()
        {
            using (var db = new CDCatalogEntities1())
            {
                try
                {
                    return db.Genres.OrderBy(o => o.GenreName).ToList();
                }
                catch (Exception ex)
                {
                    // Define a new top-level error message.
                    string str = "Listing the Genres failed. " + ex.Message;

                    // Pop-up a messagebox with the message
                    MessageBox.Show(str);
                }
            }
            return null;
        }

        public static int AddGenre(string genreName)
        {

            if (genreName == null)
            {
                // Define a new top-level error message.
                string str = "You did not enter a Genre Name.  Cancel this operation?";

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
                return 0;
            }
            var genre = new CDCatalogEF.Genre();
            try
            {
                genre.GenreName = genreName;

                using (var db = new CDCatalogEntities1())
                {
                    db.Genres.Add(genre);
                    var resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Adding the Genre by Name failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            var genreId = genre.GenreID;
            return genreId;
        }

        public static CDCatalogEF.Genre GetGenreById(int genreId)
        {
            var genre = new CDCatalogEF.Genre();
            try
            {
                using (var db = new CDCatalogEntities1())
                {
                    genre = db.Genres.Where(a => a.GenreID == genreId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Getting the Genre failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return genre;
        }

        public static bool DeleteGenreById(int genreId)
        {
            try
            {
                using (var db = new CDCatalogEntities1())
                {
                    CDCatalogEF.Genre genre = db.Genres.Where(n => n.Equals(genreId)).Single();
                    db.Genres.Remove(genre);
                    return true;  //if there is an exception, this won't run
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Deleting the Genre failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return false;
        }
    }
}
