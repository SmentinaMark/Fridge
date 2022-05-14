namespace FridgeAPI.Data.Models
{
    public class Fridge
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Owner { get; set; }

        public Guid FridgeModelId { get; set; }
        public Fridge_Model FridgeModel { get; set; } = new();

        public List<Product> Products { get; set; } = new();
        public List<Fridge_Product> Fridge_Products { get; set; } = new();
    }
}
