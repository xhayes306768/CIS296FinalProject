using System.ComponentModel.DataAnnotations.Schema;

namespace CIS296FinalProject.Models
{
    public class User
    {
        internal string UserName;

        [NotMapped]
        public IList<string> RoleNames { get; set; }

        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; internal set; }
    }
}
