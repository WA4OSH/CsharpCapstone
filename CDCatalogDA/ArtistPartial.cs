using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDCatalogEF;

namespace CDCatalogDA
{
    public partial class Artist 
    {
        public static List<CDCatalogEF.Artist> GetAllArtists()
        {
            using (var db = new CDCatalogEntities1())
            {
                try
                {
                    return db.Artists.OrderBy(o => o.ArtistName).ToList();
                }
                catch (Exception ex)
                {
                    // Define a new top-level error message.
                    string str = "Listing the Artists failed. " + ex.Message;

                    // Pop-up a messagebox with the message
                    MessageBox.Show(str);
                }
            }
            return null;      
        }

        public static int AddArtist(string artistName)
        {
            var artist = new CDCatalogEF.Artist();

            try
            {
                artist.ArtistName = artistName;

                using (var db = new CDCatalogEntities1())
                {
                    db.Artists.Add(artist);
                    var resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Adding the Artist by Name failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            var artistId = artist.ArtistID;
            return artistId;
        }

        public static CDCatalogEF.Artist GetArtistById(int artistId)
        {
            var artist = new CDCatalogEF.Artist();
            try
            {
                using (var db = new CDCatalogEntities1())
                {
                    artist = db.Artists.Where(a => a.ArtistID == artistId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Getting the Artist failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return artist;
        }

        public static bool DeleteAtristById(int artistId)
        {
            try
            {
                using (var db = new CDCatalogEntities1())
                {
                    CDCatalogEF.Artist artist = db.Artists.Where(n => n.Equals(artistId)).Single();
                    db.Artists.Remove(artist);
                    return true;  //if there is an exception, this won't run
                }
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "Deleting the Artist failed. " + ex.Message;

                // Pop-up a messagebox with the message
                MessageBox.Show(str);
            }
            return false;
       }
   }
}
