namespace TeamApi.Models

{
    public class FavoriteBreakfastFood
    {
        public int Id { get; set; }          // Primary key
        public string Name { get; set; }     // Name of the food (e.g., Pancakes, Eggs)
        public string Type { get; set; }     // Type of food (e.g., Sweet, Savory)
        public bool IsHealthy { get; set; }  // Whether the food is considered healthy
        public string Description { get; set; } // A brief description of the food
    }
}
