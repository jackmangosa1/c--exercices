using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.Services
{
    public class MemberService
    {
        List<Member> members = new List<Member>();

        public OperationResult<Member> CreateMember(string name, string email, string phoneNumber)
        {
            try
            {
                Member newMember = new Member(name, email, phoneNumber);
                members.Add(newMember);
                return new OperationResult<Member>(true, "Member created", newMember);

            }
            catch (Exception ex)
            {
                return new OperationResult<Member>(false, ex.Message, null);
            }
        }

        public OperationResult<IEnumerable<Member>> GetMembers()
        {
            try
            {
                if (members.Count == 0)
                {
                    return new OperationResult<IEnumerable<Member>>(false, "No members found", Enumerable.Empty<Member>());
                }

                IEnumerable<Member> memberIterator = CollectionIterator.GetIterator(members);

                return new OperationResult<IEnumerable<Member>>(true, "Members found", memberIterator);
            }
            catch (Exception ex)
            {
                return new OperationResult<IEnumerable<Member>>(false, ex.Message, null);
            }
        }

    }
}
