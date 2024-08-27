using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utilities;


namespace LibraryManagementSystem.Services
{
    public class LoanService
    {
        private BookService _bookService;
        private List<Loan> loans = new List<Loan>();

        public LoanService(BookService bookService)
        {
            _bookService = bookService;
        }

        public OperationResult<IEnumerable<Loan>> GetLoans()
        {
            try
            {
                if (loans.Count == 0)
                {
                    return new OperationResult<IEnumerable<Loan>>(false, "No Loans found", Enumerable.Empty<Loan>());
                }

                IEnumerable<Loan> loanIterator = CollectionIterator.GetIterator(loans);

                return new OperationResult<IEnumerable<Loan>>(true, "Loans found", loanIterator);

            }
            catch (Exception ex)
            {
                return new OperationResult<IEnumerable<Loan>>(false, ex.Message, null);
            }
        }


        public OperationResult<Book> BorrowBook(Guid bookId, Guid memberId, DateTime returnDate, DateTime dueDate)
        {
            OperationResult<IEnumerable<Book>> bookResult = _bookService.GetBooks();
            if (!bookResult.Success)
            {
                return new OperationResult<Book>(false, bookResult.Message, null);
            }

            Book book = bookResult.Data.FirstOrDefault(b => b.BookID == bookId);
            if (book == null)
            {
                return new OperationResult<Book>(false, "Book not found", null);
            }

            if (book.CopiesAvailable <= 0)
            {
                return new OperationResult<Book>(false, "No copies available", null);
            }

            Loan loan = new Loan(bookId, memberId, dueDate);
            loans.Add(loan);
            book.CopiesAvailable--;

            return new OperationResult<Book>(true, "Book borrowed Successfully", book);
        }

        public OperationResult<Book> ReturnBook(Guid bookId, Guid memberId, DateTime returnDate)
        {
            try
            {
                OperationResult<IEnumerable<Book>> bookResult = _bookService.GetBooks();
                if (!bookResult.Success)
                {
                    return new OperationResult<Book>(false, bookResult.Message, null);
                }

                Book book = bookResult.Data.FirstOrDefault(b => b.BookID == bookId);
                if (book == null)
                {
                    return new OperationResult<Book>(false, "Book not found", null);
                }


                Loan loan = loans.FirstOrDefault(l => l.BookID == bookId && l.MemberID == memberId && !l.ReturnDate.HasValue);
                if (loan == null)
                {
                    return new OperationResult<Book>(false, "No active loan found for this book and member", null);
                }


                loan.ReturnDate = returnDate;


                book.CopiesAvailable++;

                return new OperationResult<Book>(true, "Book returned Successfully", book);
            }
            catch (Exception ex)
            {
                return new OperationResult<Book>(false, ex.Message, null);
            }
        }
    }
}
