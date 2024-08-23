using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.Services
{
    internal class BookService
    {
        private  List<Book> books = new List<Book>();
       
       
        public OperationResult<IEnumerable<Book>> GetBooks()
        {
            try
            {
                if(books.Count == 0)
                {
                    return new OperationResult<IEnumerable<Book>>(false, "No books found", null);
                }

                IEnumerable<Book> bookIterator =  CollectionIterator.GetIterator(books);
               
                return new OperationResult<IEnumerable<Book>>(true, "Books found", bookIterator);

            } catch (Exception ex)
            {
                return new OperationResult<IEnumerable<Book>>(false, ex.Message, null);
            }
        }
        

        public OperationResult<Book> CreateBook(string title, string author, string ISBN, string genre, int copies)
        {
            try
            { 
                if (books.Any(b => b.ISBN == ISBN))
                {
                    return new OperationResult<Book>(false, "Book with the same ISBN already exists.", null);
                }

                Book newBook = new Book(title, author, ISBN, genre, copies);
                books.Add(newBook);
                OperationResult<Book> result = new OperationResult<Book>(true, "Book created successfully", newBook);
                return result;
            }
            catch (Exception ex) { 
                return new OperationResult<Book>(false, ex.Message, null);
            
            }

            
        }

        public OperationResult<Book> UpdateBook(Guid bookId, string title, string author, string ISBN, string genre, int copies)
        {
            try
            {
                
                Book bookToUpdate = books.FirstOrDefault(b => b.BookID == bookId);
                OperationResult<Book> result;

                if(bookToUpdate == null)
                {
                    result = new OperationResult<Book>(false, "Book not found", null);
                    return result;
                }

                bookToUpdate.Title = title;
                bookToUpdate.Author = author;
                bookToUpdate.ISBN = ISBN;
                bookToUpdate.Genre = genre;
                bookToUpdate.CopiesAvailable = copies;

                result = new OperationResult<Book>(true, "Book updated successfully", bookToUpdate);
                return result;

                


            } catch(Exception ex)
            {
                OperationResult<Book> result = new OperationResult<Book>(false, ex.Message, null);
                return result;
            }
        }

        public OperationResult<Book> DeleteBook(Guid bookId)
        {
            try
            {
                if(books.FirstOrDefault(b => b.BookID == bookId) == null)
                {
                    return new OperationResult<Book>(false, "Book not found", null);
                }
                Book bookToDelete = books.FirstOrDefault(b => b.BookID == bookId);
                books.Remove(bookToDelete);
                return new OperationResult<Book>(true, "Book deleted successfully", bookToDelete);
            }
            catch (Exception ex)
            {
                return new OperationResult<Book>(false, ex.Message, null);
            }

        }

     
    }
  
}
