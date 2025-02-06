using Microsoft.AspNetCore.Identity;

namespace EventScheduler.Data.Models
{
    public partial class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Events = new HashSet<Event>();
        }

        public virtual ICollection<Event> Events { get; set; }

    }
}
