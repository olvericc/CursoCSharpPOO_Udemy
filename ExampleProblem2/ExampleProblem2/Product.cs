using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExampleProblem2 {
    internal class Product {

        // class attributes
        public string Name;
        public double Price;
        public int Quantity;

        // method TotalValueInStock()
        public double TotalValueInStock() {
            return Price * Quantity;
        }

        // method AddProducts()
        public void AddProducts(int quantity) {
            Quantity += quantity;
        }

        // method RemoveProducts()
        public void RemoveProducts(int quantity) {
            Quantity -= quantity;
        }

        // method ToString()
        public override string ToString() {
            return Name 
                + ", $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " units in stock, total: $"
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
