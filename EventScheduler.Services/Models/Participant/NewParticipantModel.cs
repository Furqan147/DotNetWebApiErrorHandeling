using System.ComponentModel.DataAnnotations;

namespace EventScheduler.Services.Models.Participant
{
    public class NewParticipantModel
    {
        [Required]
        public Guid EventId { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        public string? Occupation { get; set; }
    }
}
