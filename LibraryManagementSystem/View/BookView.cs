using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.View
{
    public class BookView
    {
        private readonly BookService _bookService;

        public BookView(BookService bookService)
        {
            _bookService = bookService;
        }

        public void GetBooks()
        {
            OperationResult<IEnumerable<Book>> result = _bookService.GetBooks();

            if (result.Success)
            {
                foreach (Book book in result.Data)
                {
                    Console.WriteLine($"\nBook title: {book.Title}\nBook author: {book.Author}\nGenre: {book.Genre}\nISBN: {book.ISBN}\nBook ID: {book.BookID}\nNumber of Copies: {book.CopiesAvailable}\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void CreateBook()
        {
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string author = Console.ReadLine();

            Console.Write("Enter the ISBN of the book: ");
            string ISBN = Console.ReadLine();

            Console.Write("Enter the genre of the book: ");
            string genre = Console.ReadLine();

            Console.Write("Enter the number of copies available: ");
            if (!int.TryParse(Console.ReadLine(), out int copies))
            {
                Console.WriteLine("Invalid number of copies.");
                return;
            }

            OperationResult<Book> result = _bookService.CreateBook(title, author, ISBN, genre, copies);
            Console.WriteLine(result.Message);
        }


        public void UpdateBook()
        {
            Console.Write("Enter the ID of the book you want to update: ");
            if (!Guid.TryParse(Console.ReadLine(), out Guid guid))
            {
                Console.WriteLine("Invalid book ID.");
                return;
            }

            OperationResult<IEnumerable<Book>> booksResult = _bookService.GetBooks();
            Book bookToUpdate = booksResult.Data?.FirstOrDefault(b => b.BookID == guid);

            if (bookToUpdate == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            Console.WriteLine("Leave blank for fields you do not want to update");

            Console.Write($"Current title: {bookToUpdate.Title}\tNew title: ");
            string title = Console.ReadLine();
            if (string.IsNullOrEmpty(title))
            {
                title = bookToUpdate.Title;
            }

            Console.Write($"Current author: {bookToUpdate.Author}\tNew author: ");
            string author = Console.ReadLine();
            if (string.IsNullOrEmpty(author))
            {
                author = bookToUpdate.Author;
            }

            Console.Write($"Current ISBN: {bookToUpdate.ISBN}\tNew ISBN: ");
            string ISBN = Console.ReadLine();
            if (string.IsNullOrEmpty(ISBN))
            {
                ISBN = bookToUpdate.ISBN;
            }

            Console.Write($"Current genre: {bookToUpdate.Genre}\tNew genre: ");
            string genre = Console.ReadLine();
            if (string.IsNullOrEmpty(genre))
            {
                genre = bookToUpdate.Genre;
            }


            int copies = bookToUpdate.CopiesAvailable;


            Console.Write($"Current number of copies available: {bookToUpdate.CopiesAvailable}\tNew number of copies: ");
            string copiesString = Console.ReadLine();
            if (string.IsNullOrEmpty(copiesString))
            {
                copies = bookToUpdate.CopiesAvailable;
            }
            else if (!string.IsNullOrEmpty(copiesString) && int.TryParse(copiesString, out int newCopies))
            {
                copies = newCopies;
            }

            OperationResult<Book> result = _bookService.UpdateBook(guid, title, author, ISBN, genre, copies);
            Console.WriteLine(result.Message);
        }

        public void DeleteBook()
        {
            Console.Write("Enter the ID of the book you want to delete: ");
            if (!Guid.TryParse(Console.ReadLine(), out Guid guid))
            {
                Console.WriteLine("Invalid book ID.");
                return;
            }
            OperationResult<Book> deletedBook = _bookService.DeleteBook(guid);
            Console.WriteLine(deletedBook.Message);
        }
    }
}
