using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {

            Box box = new Box();
            Product product1 = new Product("Product1", 1);
            Product product2 = new Product("Product2", 2);
            Product product3 = new Product("Product3", 3);

            box.AddProduct(product1);
            box.AddProduct(product2);
            box.AddProduct(product3);

            IAbstractIterator iterator = box.GetIterator();

            Product currentProduct = iterator.First();
            while (iterator.IsDone == false)
            {
                Console.WriteLine(currentProduct.ToString());
                currentProduct = iterator.Next();
            }
        }
    }
}
