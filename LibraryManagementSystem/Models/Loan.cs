using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Loan
    {
        public Guid LoanID { get; set; }
        public int BookID { get; set; }  
        public int MemberID { get; set; }  
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; } 

        public Loan(int bookID, int memberID, DateTime loanDate, DateTime dueDate)
        {
            this.LoanID = Guid.NewGuid();
            this.BookID = bookID;
            this.MemberID = memberID;
            this.LoanDate = loanDate;
            this.DueDate = dueDate;
        }
    }
}
