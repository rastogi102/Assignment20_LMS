using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter book details:");
                        Book newBook = new Book();
                        Console.Write("Book ID: ");
                        newBook.BookId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Title: ");
                        newBook.Title = Console.ReadLine();
                        Console.Write("Author: ");
                        newBook.Author = Console.ReadLine();
                        Console.Write("Genre: ");
                        newBook.Genre = Console.ReadLine();
                        Console.Write("Is Available (true/false): ");
                        newBook.IsAvailable = Convert.ToBoolean(Console.ReadLine());
                        library.AddBook(newBook);
                        Console.WriteLine("Book added successfully.");
                        break;

                    case "2":
                        library.ViewAllBooks();
                        break;

                    case "3":
                        Console.Write("Enter the Book ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case "4":
                        Console.Write("Enter the Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case "5":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
