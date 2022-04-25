using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace House
{
    public class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Name = "indomie", Quantity = 220 },
                new Product { Name = "Egg", Quantity = 150 },
                new Product { Name = "Rice", Quantity = 120 },
                new Product { Name = "Coca Cola", Quantity = 870 },
                new Product { Name = "Sugar", Quantity = 400 },
                new Product { Name = "Salt", Quantity = 100 },
                new Product { Name = "Eva Water", Quantity = 90 },
                new Product { Name = "Biscuit", Quantity = 70 },
                new Product { Name = "Milk", Quantity = 80 },
                new Product { Name = "Milo", Quantity = 0 },


            };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " : " + product.Quantity );
            }
            
            Console.WriteLine("***********************");


            products.Sort(new SortQuantity());
            foreach(Product p in products)
            {
                Console.WriteLine(p);
                
                
            }
                   
            
        }





        public class Product 
        {

            public string Name { get; set; }
            public int Quantity { get; set; }



            public override string ToString()
            {
                return $"{this.Name}.{this.Quantity}";


            }
        }
       
        public class SortQuantity : IComparer<Product> 
        {
            public int Compare(Product x, Product y)
            {
                if (x.Quantity < y.Quantity)
                {
                    return 100;

                }
                else if (x.Quantity > y.Quantity)
                {
                    return -10;
                }
                else
                {
                    return 0;
                }
               
            }
            
            
      
        }

    }
    

}
