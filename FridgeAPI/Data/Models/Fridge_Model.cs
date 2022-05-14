namespace FridgeAPI.Data.Models
{
    public class Fridge_Model
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int Year { get; set; }

        public List<Fridge> Fridges { get; set; } = new();
    }
}
