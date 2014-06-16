using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDCatalogEF;

namespace CDCatalogDA
{
    public partial class Album
    {
        public static List<CDCatalogEF.Album> GetAlbumsByTitle(string title)
        {
            using (var db = new CDCatalogEntities1())
            {
                try
                {
                    return db.Albums.Where(o => o.AlbumTitle.ToUpper().Contains(title.ToUpper())).ToList();
                }
                catch (Exception ex)
                {
                    // Define a new top-level error message.
                    string str = "Listing the Albums by name failed. " + ex.Message;

                    // Pop-up a messagebox with the message
                    MessageBox.Show(str);
                }
            }
            return null;
        }

        public static int AddAlbum(int albumYear, int artistId, string albumTitle, int albumRating, int genreId)
        {

            var album = new CDCatalogEF.Album();

            try
            {
                album.AlbumYear = albumYear;
                album.ArtistID = artistId;
                album.AlbumTitle = albumTitle;
                album.AlbumRating = albumRating;
                album.GenreID = genreId;

                using (var db = new CDCatalogEntities1())
                {
                    db.Albums.Add(album);
                    var resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Adding the Album failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            var songId = album.ArtistID; //The song.ArtistID gets updated in the context as its saved
            return artistId;
        }

        public static bool DeleteSongById(int albumId)
        {
            try
            {
                using (var db = new CDCatalogEntities1())
                {
                    CDCatalogEF.Song song = db.Songs.Where(n => n.Equals(albumId)).Single();
                    db.Songs.Remove(song);
                    return true;  //if there is an exception, this won't run
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Deleting the Album failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return false;
        }
    }
}
