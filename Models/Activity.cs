namespace DiscoverPhilippines.Models
{
    public class Activity
    {
        public int Id { get; set; }

        public int DestinationId { get; set; }

        public string Name { get; set; } = "";

        public Destination? Destination { get; set; }
    }
}