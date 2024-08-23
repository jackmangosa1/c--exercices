using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class MemberService
    {
        List<Member> members = new List<Member>();

       public OperationResult<Member> CreateMember(string name, string email, string phoneNumber, DateTime memberShipDate)
        {
            try
            {
                Member newMember = new Member(name, email, phoneNumber, memberShipDate);
                members.Add(newMember);
                return new OperationResult<Member>(true, "Member created", newMember);

            }
            catch (Exception ex) {
                return new OperationResult<Member>(false, ex.Message, null);
            }
        }

       public OperationResult<IEnumerable<Member>> GetMembers()
        {
            try
            {
                if(members.Count == 0)
                {
                    return new OperationResult<IEnumerable<Member>>(false, "No members found", Enumerable.Empty<Member>());
                }

                IEnumerable<Member> memberIterator = CollectionIterator.GetIterator(members);

                return new OperationResult<IEnumerable<Member>>(true, "Members found", memberIterator );
            } catch(Exception ex)
            {
                return new OperationResult<IEnumerable<Member>>(false, ex.Message, null);
            }
        }
    }
}
