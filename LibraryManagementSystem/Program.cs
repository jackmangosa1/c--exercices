using LibraryManagementSystem.Services;
using LibraryManagementSystem.View;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();
            MemberService memberService = new MemberService();
            LoanService loanService = new LoanService(bookService);
            BookView bookView = new BookView(bookService);
            MemberView memberView = new MemberView(memberService);
            LoanView loanView = new LoanView(loanService, bookService, memberService);
            MenuView menuView = new MenuView();

            Boolean running = true;
            while (running)
            {
                menuView.DisplayMainMenu();
                int option = menuView.GetMenuOption();

                switch (option)
                {
                    case 1:
                        bookView.CreateBook();
                        break;
                    case 2:
                        bookView.UpdateBook();
                        break;
                    case 3:
                        bookView.DeleteBook();
                        break;
                    case 4:
                        bookView.GetBooks();
                        break;
                    case 5:
                        memberView.CreateMember();
                        break;
                    case 6:
                        memberView.GetMembers();
                        break;
                    case 7:
                        loanView.GetLoans();
                        break;
                    case 8:
                        loanView.BorrowBook();
                        break;
                    case 9:
                        loanView.ReturnBook();
                        break;
                    case 10:
                        menuView.DisplayExitMessage();
                        running = false;
                        break;


                }
            }
        }
    }
}
