using System;

namespace Book
{
    class Book
    {
        public string BookName { get; }
        public string AuthorName { get; }

        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}\nAuthor Name: {AuthorName}\n");
            Console.ReadLine();
        }
    }

    class BookShelf
    {
        private Book[] books;

        public BookShelf()
        {
            books = new Book[5];
        }

        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                books[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            // Taking input from user for book names and author names
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("Book Name: ");
                string bookName = Console.ReadLine();
                Console.Write("Author Name: ");
                string authorName = Console.ReadLine();
                shelf[i] = new Book(bookName, authorName);
            }

            // Displaying the details of each book
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book at index {i}:");
                shelf[i].Display();
                Console.ReadLine();
            }
        }
    }
}
