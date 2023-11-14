

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace P06_Interfact
{
    public class ProductService
    {
        public Productmangement Productmangement { get; set; }

        public ProductService()
        {
            Productmangement = new Productmangement();
        }

        public void GenerateProduct(int number = 1)
        {
            Random random = new Random();

            for (int i = 0; i <= number; i++)
            {
                Productmangement.AddProduct(new Product
                {
                    Id = i,
                    Name = "Coffee",
                    Price = random.Next(10, 200)
                });
            }
        }

        public void DisplayProduct()
        {
            foreach (var item in Productmangement.GetProducts())
            {
                Console.WriteLine($"{item.Id,5}{item.Name,-10}{item.Price,5}");
            }
        }
        public List <Product> OrderByPrice()
        {
            var sort = Productmangement.Products.OrderBy(x => x.Price).ToList();
            return sort;
        }

        public List<TempGroup> GroupByPrice()
        {
            var temp = new List<TempGroup>();
            int tempGr;

            foreach (var item in Productmangement.Products)
            {
                tempGr = item.Price switch
                {
                    <= 100 => 1,
                    <= 200 => 2,
                    _ =>3,
                };
                temp.Add(new TempGroup { group = tempGr });
            }
            return temp;
        }
        public void DisplayGroupByPrice()
        {
            var numOfGroup = GroupByPrice().GroupBy(p => p.group);

            foreach (var item in numOfGroup)
            {
                Console.WriteLine($"{item.Key}{GroupByPrice().Count(p=>p.group == item.Key)}");
            }
        }
    }

    public class TempGroup
    {
       public int group { get; set; }
    }
}
