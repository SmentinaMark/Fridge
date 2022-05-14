namespace FridgeAPI.Data.Models
{
    public class Fridge_Product
    {
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

        public Guid FridgeId { get; set; }
        public Fridge? Fridge { get; set; }

        public int Quantity { get; set; }
    }
}
