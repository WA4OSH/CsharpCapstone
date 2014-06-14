using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDCatalogEF;

namespace CDCatalogDA
{
    public partial class Genre
    {
        public static List<CDCatalogEF.Genre> GetAllGenres()
        {
            using (var db = new CDCatalogEntities())
            {
                return db.Genres.OrderBy(o => o.GenreName).ToList();
            }
        }

        public static int AddGenre(string GenreName)
        {
            var genre = new CDCatalogEF.Genre();
            try
            {
                genre.GenreName = GenreName;

                using (var db = new CDCatalogEntities())
                {
                    db.Genres.Add(genre);
                    var resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            var genreId = genre.GenreID;
            return genreId;
        }

        public static CDCatalogEF.Genre GetGenreByID(int genreId)
        {
            var genre = new CDCatalogEF.Genre();
            try
            {
                using (var db = new CDCatalogEntities())
                {
                    genre = db.Genres.Where(a => a.GenreID == genreId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return genre;
        }

        public static bool DeleteGenre(int genreId)
        {
            var genre = new CDCatalogEF.Genre();

            try
            {
                using (var db = new CDCatalogEntities())
                {
                    genre = db.Genres.Where(n => n.Equals(genreId)).Single();
                    db.Genres.Remove(genre);
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return false;
        }
    }
}
