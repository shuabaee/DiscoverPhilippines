namespace DiscoverPhilippines.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Category { get; set; } = "";

        public string Region { get; set; } = "";

        public string Image { get; set; } = "";

        public string Description { get; set; } = "";

        public string Ingredients { get; set; } = "";
    }
}