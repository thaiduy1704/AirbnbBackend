using Core.Domain.Entities;
using Core.Domain.IdentityEntities;

namespace Core.Models.User
{
    public class CreateUserResponse : BaseModel
    {

        public ApplicationUser User { get; set; }
        // public ICollection<string> RoleList { get; set; } = new List<string>();
        public List<string> RoleList { get; set; }
    }
}