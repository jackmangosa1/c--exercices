using LibraryManagementSystem.Services;
using LibraryManagementSystem.View;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();
            BookView bookView = new BookView(bookService);
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
                    case 6:
                        menuView.DisplayExitMessage(); 
                        running = false;
                        break;
                    

                }
            }
        }
    }
}
