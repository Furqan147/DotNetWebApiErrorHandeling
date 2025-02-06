using System.ComponentModel.DataAnnotations;

namespace EventScheduler.Services.Models.Speaker
{
    public class NewSpeakerModel
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;
        public string? Occupation { get; set; }
        public string? Website { get; set; }
        public string? Linkedin { get; set; }
        public string? Twitter { get; set; }

        [Required]
        public Guid EventId { get; set; }
    }
}
