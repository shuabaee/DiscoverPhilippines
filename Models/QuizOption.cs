namespace DiscoverPhilippines.Models
{
    public class QuizOption
    {
        public int Id { get; set; }

        public int QuizQuestionId { get; set; }

        public string OptionText { get; set; } = "";

        public bool IsCorrect { get; set; }

        public QuizQuestion? Question { get; set; }
    }
}