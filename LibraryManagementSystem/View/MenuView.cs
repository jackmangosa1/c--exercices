namespace LibraryManagementSystem.View
{
    public class MenuView
    {
        public void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Create Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Books");
            Console.WriteLine("5. Add a member");
            Console.WriteLine("6. View All members");
            Console.WriteLine("7. View All loans");
            Console.WriteLine("8. Create a Loan");
            Console.WriteLine("9. Return a Book");
            Console.WriteLine("10. Exit");
            Console.WriteLine();
        }

        public int GetMenuOption()
        {
            Console.Write("Select an option: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
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
                case 7:
                case 8:
                case 9:
                case 10:
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
