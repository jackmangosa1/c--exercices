using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.View
{
    internal class MenuView
    {
        public void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Create Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Books");
            Console.WriteLine("5. Add a member");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }

        public int GetMenuOption()
        {
            Console.Write("Select an option: ");
           if(!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option. Please try again.");
                return GetMenuOption();
            }


            
            switch (option)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    return option;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    return GetMenuOption();
            }
        }

        public void DisplayExitMessage()
        {
            Console.WriteLine("Exiting the application. Goodbye!");
        }
    }

}
