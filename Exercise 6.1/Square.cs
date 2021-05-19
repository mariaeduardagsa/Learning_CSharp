using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6._1
{
    class Square
    {
        private int side;
        private int area;

        public Square(int side)
        {
            this.side = side;
            calcArea();
        }

        private void calcArea()
        {
            area = side * side;
        }

        public int Side
        {
            get
            {
                return side;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }
    }
}
