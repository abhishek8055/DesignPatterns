
namespace FactoryDesignPattern.Factory
{
    using FactoryDesignPattern.ConcreteProducts;
    using FactoryDesignPattern.Products;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ProductFactory
    {
        private static IProduct _product;
        public static IProduct GetProduct(string type, decimal price, decimal discount)
        {
            if (type == "Smartphone")
            {
                _product = new Smartphone(price, discount);
            }
            else if (type == "Laptop")
            {
                _product = new Laptop(price, discount);
            }

            return _product;
        }
    }
}
