namespace LibraryManagementSystem.Models
{
    public class Loan
    {
        public Guid LoanID { get; set; }
        public Guid BookID { get; set; }
        public Guid MemberID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Loan(Guid bookID, Guid memberID, DateTime dueDate)
        {
            this.LoanID = Guid.NewGuid();
            this.BookID = bookID;
            this.MemberID = memberID;
            this.LoanDate = DateTime.Now;
            this.DueDate = dueDate;
        }


    }
}
