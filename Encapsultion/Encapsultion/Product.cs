using System;
using System.Globalization;

namespace Constructors {
    internal class Product {

        // class attributes
        private string _name;
        private double _price;
        private int _quantity; 

        // default builder
        public Product() {
        }

        // constructor with arguments
        public Product(string name, double price, int quantity) {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // properties
        public string Name {
            get { return _name;  }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public double Price {
            get { return _price; }
        }

        public int Quantity {
            get { return _quantity; }
        }

        // method TotalValueInStock()
        public double TotalValueInStock() {
            return _price * _quantity;
        }

        // method AddProducts()
        public void AddProducts(int quantity) {
            _quantity += quantity;
        }

        // method RemoveProducts()
        public void RemoveProductcs(int quantity) {
            _quantity -= quantity;
        }

        // method ToString()
        public override string ToString() {
            return _name
                    + ", $ "
                    + _price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + _quantity
                    + " units, total: $ "
                    + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
