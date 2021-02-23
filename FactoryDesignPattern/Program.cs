namespace FactoryDesignPattern
{
    using FactoryDesignPattern.Factory;
    using FactoryDesignPattern.Products;
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            IProduct product = ProductFactory.GetProduct("Smartphone", 20000, 10);
            product.GetProductType();
            product.GetHashCode();
            product.GetPrice();
            product.GetDiscount();

            IProduct product2 = ProductFactory.GetProduct("Laptop", 50000, 15);
            product2.GetProductType();
            product2.GetHashCode();
            product2.GetPrice();
            product2.GetDiscount();

            Console.ReadKey();
        }
    }
}
