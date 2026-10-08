namespace DiscoverPhilippines.Models
{
    public class QuizQuestion
    {
        public int Id { get; set; }

        public string QuestionText { get; set; } = "";

        public string Category { get; set; } = "";

        public List<QuizOption> Options { get; set; } = new();
    }
}