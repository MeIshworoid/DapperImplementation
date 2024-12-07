namespace DapperImplementation.BusinessLogic.Layer.Models
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required DateTime PublishedDate { get; set; }
        public required decimal Price { get; set; }
    }
}
