using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.View
{
    public class MemberView
    {
        private readonly MemberService _memberService;

        public MemberView(MemberService memberService)
        {
            _memberService = memberService;
        }

        public void GetMembers()
        {
            OperationResult<IEnumerable<Member>> result = _memberService.GetMembers();

            if (result.Success)
            {
                foreach (Member member in result.Data)
                {
                    Console.WriteLine($"\nMember name: {member.Name}\nMember ID: {member.MemberID}\nMember Email: {member.Email}\nMember Phone number: {member.PhoneNumber}\nMembership Date: {member.MembershipDate}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void CreateMember()
        {
            Console.Write("Enter the name of the member: ");
            string name = Console.ReadLine();

            Console.Write("Enter the email of the member: ");
            string email = Console.ReadLine();

            Console.Write("Enter the phone number of the member: ");
            string phoneNumber = Console.ReadLine();


            OperationResult<Member> result = _memberService.CreateMember(name, email, phoneNumber);
            Console.WriteLine(result.Message);
        }
    }
}
