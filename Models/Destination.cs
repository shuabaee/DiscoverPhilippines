namespace DiscoverPhilippines.Models
{
    public class Destination
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Location { get; set; } = "";

        public string Badge { get; set; } = "";

        public string Image { get; set; } = "";

        public string Description { get; set; } = "";

        public string FullDescription { get; set; } = "";

        public string BestTime { get; set; } = "";

        public string RecommendedStay { get; set; } = "";

        public List<Activity> Activities { get; set; } = new();

        public List<Review> Reviews { get; set; } = new();
    }
}