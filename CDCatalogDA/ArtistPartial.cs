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
        public static List<CDCatalogEF.Artist> GetAllArtists()
        {
            using (var db = new CDCatalogEntities())
            {
                 return db.Artists.OrderBy(o => o.ArtistName).ToList();
            }       
        }

        public static int AddArtist(string artistName)
        {
            var artist = new CDCatalogEF.Artist();

            try
            {
                artist.ArtistName = artistName;

                using (var db = new CDCatalogEntities())
                {
                    db.Artists.Add(artist);
                    var resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            var artistId = artist.ArtistID;
            return artistId;
        }

        public static CDCatalogEF.Artist GetArtistById(int artistId)
        {
            var artist = new CDCatalogEF.Artist();
            try
            {
                using (var db = new CDCatalogEntities())
                {
                    artist = db.Artists.Where(a => a.ArtistID == artistId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                    string s = ex.Message;
            }
            return artist;
        }

        public static bool DeleteAtristById(int artistId)
        {
            var artist = new CDCatalogEF.Artist();

            try
            {
                using (var db = new CDCatalogEntities())
                {
                    artist = db.Artists.Where(n => n.Equals(artistId)).Single();
                    db.Artists.Remove(artist);
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
