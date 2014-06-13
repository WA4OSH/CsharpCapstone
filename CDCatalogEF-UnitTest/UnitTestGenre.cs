using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Data;

namespace CDCatalogEF
{
    /// <summary>
    /// UnitTestGenre creates a unique genre and adds it to the database.
    /// Then, it fetches and deletes it.
    /// </summary>
    [TestClass]
    public class UnitTestGenre
    {
        public UnitTestGenre()
        {
        }

        [TestMethod]
        public void TestGenreAdd()
        {
            //create a new context
            using (var ctx = new CDCatalogEntities())
            {
                //create a test genre
                Genre g = new Genre();
                g.GenreID = 0;  // auto incremented and set by add
                g.GenreName = "Test Genre W6YderKT";
                //add it to the context
                ctx.Genres.Add(g);
                //verify that .. records were changed
                int count = ctx.SaveChanges();
                Assert.IsTrue(count > 0 && g.GenreID > 0, "No Records Changed");
            }
        }

        [TestMethod]
        public void TestGenreFetch()
        {
            using (var ctx = new CDCatalogEntities())
            {
                //Find the test genre in the database
                Genre g = ctx.Genres.Where(n => n.GenreName.ToLower().Equals("test genre w6yderkt")).FirstOrDefault();
                Assert.IsTrue(g != null, "No Record Found");
            }
        }

        [TestMethod]
        public void TestGenreDelete()
        {
            using (var ctx = new CDCatalogEntities())
            {
                //find the list of "Test Genre"
                //in case duplicates were added in the previous tests
                var list = ctx.Genres
                .Where(n => n.GenreName.ToLower().Equals("test genre w6yderkt"))
                .Where(n => n.GenreID > 1000);

                ctx.Genres.RemoveRange(list);
                int count = ctx.SaveChanges();
                Assert.IsTrue(count > 0, "No Record Deleted");
            }
        }
    }
}

