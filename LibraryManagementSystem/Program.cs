using LibraryManagementSystem.Enums;
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

                switch ((MenuOption)option)
                {
                    case MenuOption.CreateBook:
                        bookView.CreateBook();
                        break;
                    case MenuOption.UpdateBook:
                        bookView.UpdateBook();
                        break;
                    case MenuOption.DeleteBook:
                        bookView.DeleteBook();
                        break;
                    case MenuOption.GetBooks:
                        bookView.GetBooks();
                        break;
                    case MenuOption.CreateMember:
                        memberView.CreateMember();
                        break;
                    case MenuOption.GetMembers:
                        memberView.GetMembers();
                        break;
                    case MenuOption.GetLoans:
                        loanView.GetLoans();
                        break;
                    case MenuOption.BorrowBook:
                        loanView.BorrowBook();
                        break;
                    case MenuOption.ReturnBook:
                        loanView.ReturnBook();
                        break;
                    case MenuOption.Exit:
                        menuView.DisplayExitMessage();
                        running = false;
                        break;
                }
            }
        }
    }
}
