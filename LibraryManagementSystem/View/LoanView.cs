using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.View
{
    public class LoanView
    {
        private LoanService _loanService;
        private BookService _bookService;
        private MemberService _memberService;

        public LoanView(LoanService loanService, BookService bookService, MemberService memberService)
        {
            _loanService = loanService;
            _bookService = bookService;
            _memberService = memberService;
        }

        public void GetLoans()
        {
            OperationResult<IEnumerable<Loan>> loanResult = _loanService.GetLoans();
            if (!loanResult.Success)
            {
                Console.WriteLine(loanResult.Message);
                return;
            }

            OperationResult<IEnumerable<Book>> bookResult = _bookService.GetBooks();
            if (!bookResult.Success)
            {
                Console.WriteLine(bookResult.Message);
                return;
            }

            OperationResult<IEnumerable<Member>> memberResult = _memberService.GetMembers();
            if (!memberResult.Success)
            {
                Console.WriteLine(memberResult.Message);
                return;
            }

            var books = bookResult.Data.ToDictionary(b => b.BookID, b => b);
            var members = memberResult.Data.ToDictionary(m => m.MemberID, m => m);

            foreach (Loan loan in loanResult.Data)
            {
                if (books.TryGetValue(loan.BookID, out Book book) &&
                    members.TryGetValue(loan.MemberID, out Member member))
                {
                    Console.WriteLine($"\nMember Name: {member.Name}");
                    Console.WriteLine($"Book Title: {book.Title}");
                    Console.WriteLine($"Loan Date: {loan.LoanDate}");
                    Console.WriteLine($"Due Date: {loan.DueDate}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Loan with ID {loan.LoanID} has missing book or member information.");
                }
            }
        }

        public void BorrowBook()
        {
            Console.Write("Enter the Book ID to borrow:");
            if (!Guid.TryParse(Console.ReadLine(), out Guid bookId))
            {
                Console.WriteLine("Invalid Book ID.");
                return;
            }

            Console.Write("Enter the Member ID:");
            if (!Guid.TryParse(Console.ReadLine(), out Guid memberId))
            {
                Console.WriteLine("Invalid Member ID.");
                return;
            }



            Console.Write("Enter the Due Date (yyyy-mm-dd):");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                Console.WriteLine("Invalid Due Date.");
                return;
            }

            OperationResult<Book> borrowResult = _loanService.BorrowBook(bookId, memberId, DateTime.Now, dueDate);
            if (borrowResult.Success)
            {
                Console.WriteLine($"Book borrowed Successfully:\nTitle: {borrowResult.Data.Title}");
            }
            else
            {
                Console.WriteLine($"Error: {borrowResult.Message}");
            }
        }

        public void ReturnBook()
        {
            Console.Write("Enter the Book ID to return: ");
            if (!Guid.TryParse(Console.ReadLine(), out Guid bookId))
            {
                Console.WriteLine("Invalid Book ID.");
                return;
            }

            Console.Write("Enter the Member ID: ");
            if (!Guid.TryParse(Console.ReadLine(), out Guid memberId))
            {
                Console.WriteLine("Invalid Member ID.");
                return;
            }



            OperationResult<Book> returnResult = _loanService.ReturnBook(bookId, memberId, DateTime.Now);
            if (returnResult.Success)
            {
                Console.WriteLine($"Book returned Successfully:\nTitle: {returnResult.Data.Title}");
            }
            else
            {
                Console.WriteLine($"Error: {returnResult.Message}");
            }
        }
    }

}
