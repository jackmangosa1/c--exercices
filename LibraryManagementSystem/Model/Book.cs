namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public Guid BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public int CopiesAvailable { get; set; }


        public Book(string title, string author, string ISBN, string genre, int copies)
        {
            this.BookID = Guid.NewGuid();
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
            this.Genre = genre;
            this.CopiesAvailable = copies;
        }


    }
}
