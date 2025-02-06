using System.ComponentModel.DataAnnotations;

namespace EventScheduler.Services.Models.Event
{
    public abstract class BaseEventModel
    {
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        
        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }
        public string? Location { get; set; }
        public bool IsOnline { get; set; }
        public int? MaxCapacity { get; set; }
    }

    public class NewEventModel : BaseEventModel
    {
    }
}
