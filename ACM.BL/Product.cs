using System.Xml.Linq;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        
        public string ProductName { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        
         
        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(ProductName);

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }
        
        public bool Save()
        {
            return true;
        }
        
    }
}