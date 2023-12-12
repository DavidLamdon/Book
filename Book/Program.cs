using System.Drawing;

namespace BookApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            //create Hobbit book
            int maxPages = 320;
            Book fiction = new Book("Hobbit", maxPages);
            fiction.PrintBookDetails();

            //read 50 pages overnight
            fiction.Read(50);
            fiction.PrintBookDetails();

            //go back to chapter 2 (page 43) and read one page
            fiction.SetCurrentPage(43);
            fiction.PrintBookDetails();
            fiction.Read();
            fiction.PrintBookDetails();

            if (fiction.IsFinished())
            {
                Console.WriteLine("I finished the book!");
            }
            else
            {
                Console.WriteLine("Read " + fiction.GetPagesTillTheEnd() + " more pages!");
            }

        }
    }
}

    
