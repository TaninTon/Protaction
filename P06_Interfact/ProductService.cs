

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
                    Price = random.Next(10, 200),
                    Producttype = random.Next(1,6),
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
            int tempT;

            foreach (var item in Productmangement.Products)
            {
                tempGr = item.Price switch
                {
                    <= 100 => 1,
                    <= 200 => 2,
                    _ =>3,
                };
                tempT = item.Producttype;
                temp.Add(new TempGroup {
                    group = tempGr, 
                    group_type  = tempT 
                });
            }
            return temp;
        }
        public void DisplayGroupByPrice()
        {
            var shotofGroup = GroupByPrice().OrderBy(e => e.group);
            var numofGroup = shotofGroup.GroupBy(e => e.group);
            foreach (var item in numofGroup)
            {
                Console.Write($"{item.Key}");
                for (var i = 1; i <= 5; i++)
                {
                    Console.Write($"{item.Count(e => e.group_type == i), 5}");
                }
                Console.WriteLine();
            }
        }
        public string NameOfPrice(int Price)
        {
            return Price switch
            {
                1 => "10-100",
                2 => "101-200",
                _ => "  ",
            };


        }

        public Product SearchProduct()
        {
            Console.Write("Enter Id");
            var id = int.Parse(Console.ReadLine());

            var result = Productmangement.GetProductById(id);
            if (result == null)
            {
                Console.WriteLine("Not found");

            }
            else
            {
                Console.WriteLine($"{result.Id,5}{result.Name,5}{result.Price,5}" +
                $"{result.Producttype,5}");
            }
          
                return result;
            
        }
        public void SearchByAny()
        {

            Console.Write("Enter number");
            var number = int.Parse(Console.ReadLine());

            Console.Write("Enter keyword");
            var keyword = int.Parse(Console.ReadLine());

            var result = Productmangement.GetProductByAny(number);
            if (result.Count == 0 )Console.WriteLine("Not found");
            else
            {
              result.ForEach (x => Console.WriteLine($"{x.Id,5}{x.Name,5}{x.Price,5}" +
                $"{x.Producttype,5}"));
            }
        }

        public void DeleteProductById()
        {
            var result = SearchProduct();

            if (result == null) return;

            Productmangement.DeleteById(result);

            Console.WriteLine();
            DisplayProduct();
        }
    }
   
    public class TempGroup
    {
       public int group { get; set; }
       public int group_type { get; set; }
    }

}
