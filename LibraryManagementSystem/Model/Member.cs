namespace LibraryManagementSystem.Models
{
    public class Member
    {
        public Guid MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MembershipDate { get; set; }

        public Member(string name, string email, string phoneNumber)
        {
            this.MemberID = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.MembershipDate = DateTime.Now;
        }


    }
}
