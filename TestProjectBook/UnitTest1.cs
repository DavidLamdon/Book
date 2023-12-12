using BookApp;

namespace TestProjectBook
{
    [TestClass]
    public class UnitTest1
    {
        Book b = new Book("Test", 50);
        
        [TestMethod]
        public void TestBookRead()
        {
            b.SetCurrentPage(49);
            b.Read();
            Assert.IsTrue(b.IsFinished());

        }
    }
}