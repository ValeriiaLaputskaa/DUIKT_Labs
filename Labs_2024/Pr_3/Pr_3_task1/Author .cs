using System;

namespace Pr_3.Pr_3_task1
{
    public class Author
    {
        private string author;

        public Author(string authorOfBook)
        {
            author = authorOfBook;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Author: \t" + author);
            Console.ResetColor();
        }
    }
}