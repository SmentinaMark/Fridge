namespace FridgeAPI.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name{ get; set; } = null!;
        public int DefaultQuantity { get; set; }

        public List<Fridge> Fridges { get; set; } = new();
        public List<Fridge_Product> Fridge_Products { get; set; } = new();
    }
}
