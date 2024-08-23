using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Fine
    {
        public Guid FineID { get; set; }           
        public int MemberID { get; set; }         
        public decimal Amount { get; set; }       
        public string Reason { get; set; }       
        public DateTime DateIssued { get; set; }  
        public bool IsPaid { get; set; }

        public Fine(int memberId, decimal amount, string reason, DateTime dateIssued, Boolean isPaid)
        {
            this.FineID = Guid.NewGuid();
            this.MemberID = memberId;
            this.Amount = amount;
            this.Reason = reason;
            this.DateIssued = dateIssued;
            this.IsPaid = isPaid;
        }
    }
}
