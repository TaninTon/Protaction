

namespace P06_Interfact 
{
    // สืบถ่อดจาก interface เอาไว้เติมใส่ในโค้ด
    public class Productmangement : Iproductmangement
    {
        //หน้าคุณสมบัติ
        public List<Product> Products { get; set; }
        //conductter ส่วน
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
