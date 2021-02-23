namespace FactoryDesignPattern.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IProduct
    {
        string ProductType { get; }
        decimal Price { get; set; }
        decimal Discount { get; set; }
        void GetPrice();
        void GetDiscount();
        void GetProductType();
    }
}
