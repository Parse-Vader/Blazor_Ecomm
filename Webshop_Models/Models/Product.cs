namespace Webshop_Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public double ? Price { get; set; } 
        
        public IEnumerable<ProductProp> ProductProperties { get; set; }

    }
}