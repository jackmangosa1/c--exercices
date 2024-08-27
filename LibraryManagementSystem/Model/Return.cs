namespace LibraryManagementSystem.Models
{
    public class Return
    {
        public Guid ReturnID { get; set; }
        public Guid LoanID { get; set; }
        public DateTime ReturnDate { get; set; }

        public Return(Guid loanID, DateTime returnDate)
        {
            this.ReturnID = Guid.NewGuid();
            this.LoanID = loanID;
            this.ReturnDate = returnDate;

        }



    }
}
