

namespace P06_Interfact 
{
    //นำข้อมุลลงไปในแท็คไฟร์ 
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

       
        public Product GetProductById(int productid)
        {
            //Products.Where(p=>p.Id == productId).FirstOrDefault();
            //Products.FirstOrDefault(p => p.Id == productId);
            return Products.FirstOrDefault(p => p.Id == productid);
        }

        public List<Product> GetProductByAny(int number, string keyword=" ")
        {
            if(string.IsNullOrEmpty(keyword)) keyword = "XXX";
           var result =  Products.Where(p => p.Name.ToUpper().Contains(keyword.ToUpper())||
            p.Id.Equals(number)||
            p.Price > number ||
            p.Producttype.Equals(number)).ToList();



            return result;
        }

        public void DeleteById(Product product)
        {
            if(product==null) return;
            Products.Remove(product);
        }

        public void UpdaterProduct(Product Newproduct, Product OldProduct)
        {
            var index = Products.IndexOf(OldProduct);
            Products.Remove(OldProduct);
            Products.Insert(0, Newproduct);
        }

        public Product InputProduct(Product product)
        {
            Console.WriteLine("Input Id" + product.Id);
       
            Console.Write("Input Name");
            product.Name = (Console.ReadLine());
            Console.Write("Input Price");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Input Producttype");
            product.Producttype = int.Parse(Console.ReadLine());

            return product;

        }
    }
}
