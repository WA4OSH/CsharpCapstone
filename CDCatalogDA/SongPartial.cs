namespace CDCatalogDA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using CDCatalogEF;

    /// <summary>
    /// 
    /// </summary>
    public partial class Song
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<CDCatalogEF.Song> GetAllSongs()
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                try
                {
                    return db.Songs.OrderBy(o => o.SongTitle).ToList();
                }
                catch (Exception ex)
                {
                    // Define a new top-level error message.
                    string str = "Listing the Songs failed. " + ex.Message;

                    // Pop-up a messagebox with the message
                    MessageBox.Show(str);
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="artistId"></param>
        /// <param name="albumId"></param>
        /// <param name="trackNumber"></param>
        /// <param name="songRating"></param>
        /// <param name="trackLength"></param>
        /// <param name="genreId"></param>
        /// <returns></returns>
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
            return songId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="artistId"></param>
        /// <param name="albumId"></param>
        /// <param name="trackNumber"></param>
        /// <param name="songRating"></param>
        /// <param name="trackLength"></param>
        /// <param name="genreId"></param>
        /// <returns></returns>
        public static bool UpdateSong(int songId, string title, int artistId, int albumId, int trackNumber, int songRating, int trackLength, int genreId)
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
                    db.Songs.First(i => i.SongID == songId);
                    int resultCount = db.SaveChanges();
                    return true; // Executes only if no exception
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Adding the Song failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
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
