using System;
using System.Linq;

using CDCatalogEF;


namespace CDCatalogEF_CRUD_Operations
{
    public partial class Artist
    {

        public static int AddArtist(string artistName)
        {
            CDCatalogEF.Artist artist = new Artist();

            try
            {
                artist.ArtistName = artistName;

                using (var db = new CDCatalogEntities())
                {
                    db.Artists.Add(artist);
                    int resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            int artistId = artist.ArtistID;
            return artistId;
        }

        public static string FetchArtist(int artistID)
        {
            Artist artist = new Artist();

            try
            {
                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    artist = db.Artists.Where(n => n.Equals(artistID)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return artist.ArtistName;
        }

        public static bool DeleteAtrist(int artistID)
        {
            Artist artist = new Artist();

            try
            {
                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    artist = db.Artists.Where(n => n.Equals(artistID)).Single();
                    db.Artists.Remove(artist);
                }

            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return false;
        }

        //public static List<Artist> FetchArtistList(string title)
        //{ 
        //    List<Artist> artist = new List<Artist>();
        //
        //    using (CDCatalogEntities db = new CDCatalogEntities())
        //    {
        //
        //        return db.Artists.                     ;   .toList();
        //            artist = db.Artists
        //            foreach (var a in s)
        //           {KeyNotFoundException 
        //                a.Add(Artist.artistID, Artist.artistName);
        //            }
        //
        //
        //   }
        //
        //}
    }
}

