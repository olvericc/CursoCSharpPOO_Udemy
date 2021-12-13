using System;
using System.Globalization;

namespace Constructors {
    internal class Product {

        // class attributes
        public string Name;
        public double Price;
        public int Quantity;

        // default builder
        public Product() {
        }

        // constructor with arguments
        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // constructor with quantity = 1
        public Product(string name, double price) {
            Name = name;
            Price = price;
            Quantity = 1; // default value
        }

        // method TotalValueInStock()
        public double TotalValueInStock() {
            return Price * Quantity;
        }

        // method AddProducts()
        public void AddProducts(int quantity) {
            Quantity += quantity;
        }

        // method RemoveProducts()
        public void RemoveProductcs(int quantity) {
            Quantity -= quantity;
        }

        // method ToString()
        public override string ToString() {
            return Name
                    + ", $ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantity
                    + " units, total: $ "
                    + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
