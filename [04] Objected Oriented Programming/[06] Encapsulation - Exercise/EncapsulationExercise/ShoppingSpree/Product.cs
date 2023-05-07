﻿namespace ShoppingSpree
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        private string name;
        private decimal price;

        public string Name
        {
            get => this.name;

            private set
            {
                Validator.ValidateName(value);

                this.name = value;
            }
        }

        public decimal Price
        {
            get => this.price;

            private set
            {
                Validator.ValidateMoney(value);

                this.price = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
