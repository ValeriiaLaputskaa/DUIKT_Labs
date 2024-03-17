using System;

namespace Pr_3.Pr_3_task1
{
    public class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book()
        {
            Console.WriteLine("Enter the title of the book: ");
            string titleOfBook = Console.ReadLine();
            title = new Title(titleOfBook);

            Console.WriteLine("Enter the author of the book: ");
            string authorOfBook = Console.ReadLine();
            author = new Author(authorOfBook);

            Console.WriteLine("Enter the content of the book: ");
            string contentOfBook = Console.ReadLine();
            content = new Content(contentOfBook);
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
        public string AuthorOfBook
        {
            get { return AuthorOfBook; }
            set { AuthorOfBook = value; }
        }

        public string ContentOfBook
        {
            get { return ContentOfBook; }
            set { ContentOfBook = value; }
        }
    }
}