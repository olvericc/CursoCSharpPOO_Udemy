using System;
using System.Collections.Generic;
using System.Text;

namespace StructType {
    struct Point {

        // class attributes
        public double x;
        public double y;

        // method ToString()
        public override string ToString() {
            return "(" + x + ", " + y + ")";
        }
    }
}
