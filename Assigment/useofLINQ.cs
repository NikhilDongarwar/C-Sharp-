using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication9
{
    using System;
    using System.Linq;
    class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, Number in Stock={2}",
            Name, Description, NumberInStock);
        }
    }
    class entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");
            // This array will be the basis of our testing...
            ProductInfo[] itemsInStock = new[]
             {
        new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
                                         NumberInStock = 24},
        new ProductInfo { Name = "Milk Maid Milk",Description = "Milk cow's love",
                                            NumberInStock = 100},
         new ProductInfo{ Name = "Pure Silk Tofu",  Description = "Bland as Possible",
                                            NumberInStock = 120},
        new ProductInfo{ Name = "Cruchy Pops",  Description = "Cheezy, peppery goodness",
                                        NumberInStock = 2},
       new ProductInfo{ Name = "RipOff Water",   Description = "From the tap to your wallet",
                                        NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
         NumberInStock = 73}
            };


            var select = (from i in itemsInStock select i);
          
            foreach (var item in select)
            {
                Console.WriteLine(item);
                
            }
            //var select1 = from i in itemsInStock select i.Name;
            var res=itemsInStock.Select(i => i.Name);

            foreach (var item in select)
            {
                Console.WriteLine(item.Name);

            }
            var select2 =from i in itemsInStock select  new {des= i.Description ,name=i.Name };
            foreach (var item in select2) { Console.WriteLine(item); }

            Console.WriteLine("*******\n");

            var select3 = from i in itemsInStock where i.NumberInStock >= 100 select new { name = i.Name, i.Description };
            foreach (var item in select3) { Console.WriteLine(item); }
            Console.WriteLine("*******\n");

            var select4 = from i in itemsInStock where i.Name.Contains("s") select i.Name;
            foreach (var item in select4) { Console.WriteLine(item); }

            var select5 = from i in itemsInStock where i.Name.Contains("s") orderby i.Name descending  select i.Name;
            foreach (var item in select5) { Console.WriteLine(item); }

            var select6=(from i in itemsInStock where i.NumberInStock <= 100 select i.Name).Count();
            Console.WriteLine("Count of product with number of item in stock<100==>>" + select6);

                var select7 = itemsInStock.Where(number => number.NumberInStock <= 100).Select(data => data).Count();
            Console.WriteLine(select7);


        }

    }

}

