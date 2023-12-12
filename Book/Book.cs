using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class Book
    {
        private String name;
        private int maxPage;
        private int currentPage;

        public Book(String bookName, int max) 
        {
            name = bookName;
            maxPage = max;
        }

        public int GetCurrentPage()
        {
            return currentPage;
        }

        public void SetCurrentPage(int curPage)
        {
            currentPage = curPage;
        }
        public void PrintBookDetails()
        {
            Console.WriteLine("Book Name " + name + " maxPage " + maxPage + " Current Page " + currentPage );
        }
        public void Read()
        {
            if (!IsFinished())
            {
                currentPage++;
            }
            
        }
        public void Read(int pages)
        {
            currentPage += pages;
        }
        public bool IsFinished()
        {
            return currentPage == maxPage;
        }
        public int GetPagesTillTheEnd()
        {
            return maxPage - currentPage;
        }
    }
}
