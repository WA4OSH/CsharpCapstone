using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDCatalogEF;

namespace CDCatalogDA
{
    public partial class Song
    {
        public static List<CDCatalogEF.Song> GetSongsByTitle(string title)
        {
            using (var db = new CDCatalogEntities())
            {
                try
                {
                    return db.Songs.Where(o => o.SongTitle.ToUpper().Contains(title.ToUpper())).ToList();
                }
                catch (Exception ex)
                {
                    // Define a new top-level error message.
                    string str = "Listing the Songs by name failed. " + ex.Message;

                    // Pop-up a messagebox with the message
                    MessageBox.Show(str);
                }
            }
            return null;
        }

        public static int AddSong(string title, int artistId, int albumId, int trackNumber, int songRating, int trackLength, int genreId)
        {

            var song = new CDCatalogEF.Song();

            try
            {
                song.SongTitle = title;
                song.ArtistID = artistId;
                song.AlbumID = albumId;
                song.SongTrackNumber = trackNumber;
                song.SongRating = songRating;
                song.SongTrackLength = trackLength;
                song.GenreID = genreId;

                using (var db = new CDCatalogEntities())
                {
                    db.Songs.Add(song);
                    var resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Adding the Song failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            var songId = song.ArtistID; //The song.ArtistID gets updated in the context as its saved
            return artistId;
        }

        public static bool DeleteSongById(int songId)
        {
            try
            {
                using (var db = new CDCatalogEntities())
                {
                    CDCatalogEF.Song song = db.Songs.Where(n => n.Equals(songId)).Single();
                    db.Songs.Remove(song);
                    return true;  //if there is an exception, this won't run
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Deleting the Song failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return false;
        }
    }
}
