namespace DiscoverPhilippines.Models
{
    public class Review
    {
        public int Id { get; set; }

        // Currently used by the application
        public string Destination { get; set; } = "";

        public int Rating { get; set; }

        public string Comment { get; set; } = "";


        // Planned database relationships
        public int? UserId { get; set; }

        public int? DestinationId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User? User { get; set; }
    }
}