namespace DiscoverPhilippines.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Email { get; set; } = "";

        public string PasswordHash { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Review> Reviews { get; set; } = new();

        public List<QuizResult> QuizResults { get; set; } = new();
    }
}