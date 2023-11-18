

namespace P06_Interfact
{
    //interface เอาใช่ว่า เอาไว้ทำอะไร ใช่ในการออกแปปโครงสร้าง ไม่มีโค้ด ครีนหน้าจอ
    public interface Iproductmangement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
    }
}
