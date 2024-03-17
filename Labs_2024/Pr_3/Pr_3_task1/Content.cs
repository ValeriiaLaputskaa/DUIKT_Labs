using System;

namespace Pr_3.Pr_3_task1
{
    public class Content
    {
        private string content;

        public Content(string contentOfBook)
        {
            content = contentOfBook;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Information from the book: \t" + content);
            Console.ResetColor();
        }
    }
}