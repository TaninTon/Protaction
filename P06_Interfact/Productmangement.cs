

namespace P06_Interfact 
{
    public class Productmangement : Iproductmangement
    {
        public List<Product> Products { get; set; }
        public Productmangement()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
