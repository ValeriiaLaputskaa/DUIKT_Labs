using System;

namespace Pr_3.Pr_3_task1
{
    public class Title
    {
        private string title;

        public Title(string titleOfBook) 
        {
             title = titleOfBook; 
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: \t " + title);
            Console.ResetColor();
        }
    }
}