namespace Team8WebAPIFinal.Models
{
    public class Hobbies
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } = string.Empty; // Hobby name (e.g., Painting, Gaming)
        public string? Description { get; set; } // Brief description of the hobby
        public int EstimatedHoursPerWeek { get; set; } // Hours spent weekly
        public string SkillLevel { get; set; } = "Beginner"; // Beginner, Intermediate, Expert

    }
}