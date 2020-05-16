using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("InstarBox");
            Product gpu = new Product("MSI GF RTX 2080 Super", 7800.99, 1.5);
            Product powerSupply = new Product("Fractal Ion SFX-L 500W", 932.26, 2);
            Product monitor = new Product("AOC 27inch", 2999.99, 4);

            box.Add(gpu);
            box.Add(powerSupply);
            box.Add(monitor);
            double totalPrice = box.Price;
            double totalWeight = box.Weight;

            ShippingService service = new ShippingService(3);
            double shippingPrice = service.Price(totalWeight);

            Console.WriteLine("Total item price: " + totalPrice.ToString("0.00") + " HRK\n");
            Console.WriteLine("Total shipping price: " + shippingPrice.ToString("0.00") + " HRK");
        }
    }
}
