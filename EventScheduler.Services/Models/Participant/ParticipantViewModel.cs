namespace EventScheduler.Services.Models.Participant
{
    public class ParticipantViewModel
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Occupation { get; set; }
    }
}
