using System;
using System.Globalization;

namespace Constructors {
    internal class Product {

        // class attributes
        private string _name; // has particular logical
        public double Price { get; private set; } // prop
        public int Quantity { get; private set; } // prop

        // default builder
        public Product() {
        }

        // constructor with arguments
        public Product(string name, double price, int quantity) {
            _name = name;
            Price = price;
            Quantity = quantity;
        }

        // property Name
        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
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
            return _name
                    + ", $ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantity
                    + " units, total: $ "
                    + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
