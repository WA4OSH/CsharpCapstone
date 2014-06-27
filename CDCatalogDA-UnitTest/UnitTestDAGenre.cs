using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDCatalogDA_UnitTest
{
    /// <summary>
    /// UnitTestDAGenre tests each of the methods dealing with CDCatalogDA.Genre
    /// </summary>
    [TestClass]
    public class UnitTestDAGenre
    {
        //[TestMethod]
        //public void TestDAGetAllGenres()
        //(
        //    CDCatalogDA.Genre.GetAllGenres();
        //)

        /// <summary>
        /// The test da genre add.
        /// </summary>
        [TestMethod]
        public void TestDAGenreAdd()
        {
            CDCatalogDA.Genre.AddGenre("xyzzx");
            

        }

        //[TestMethod]
        //public void TestDAGenreDelete()
        //{
        //    CDCatalogDA.Genre.DeleteGenreById(100);
        //
        //}







    }
}
