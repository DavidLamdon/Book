using System.Drawing;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book("Oliver", 50);
            Console.WriteLine(bk.GetCurrentPage());
            bk.SetCurrentPage(49);
            Console.WriteLine(bk.GetPagesTillTheEnd());
            bk.Read();
            Console.WriteLine(bk.IsFinished());
        }
    }

}
