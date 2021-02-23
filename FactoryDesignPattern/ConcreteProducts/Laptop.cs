namespace FactoryDesignPattern.ConcreteProducts
{
    using FactoryDesignPattern.Products;
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Laptop : IProduct
    {
        private readonly string _productType;
        private decimal _price;
        private decimal _discount;

        public Laptop(decimal price, decimal discount)
        {
            _price = price;
            _discount = discount;
            _productType = "Laptop";
        }
        public string ProductType
        {
            get { return _productType; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public void GetDiscount()
        {
            Console.WriteLine("Discount: {0}%", _discount);
        }

        public void GetPrice()
        {
            Console.WriteLine("Price: {0}", _price);
        }

        public void GetProductType()
        {
            Console.WriteLine("Product Type: {0}", _productType);
        }
    }
}
