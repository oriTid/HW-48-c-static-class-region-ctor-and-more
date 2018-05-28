using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Square
    {
        public double XCoor { get; set; }
        public double YCoor { get; set; }
        public int Color { get; set; }
        private double line;

        public Square()
        {
            Console.WriteLine("A square was created !!! one day, you will even get to see it");
        }

        #region Square Functions
        public void SquareDetails()
        {
            Console.WriteLine($"Square line is {Line}");
            Console.WriteLine($"Square x Coordiante is {XCoor}");
            Console.WriteLine($"Square y Coordiante is {YCoor}");
            Console.WriteLine($"Square color-code is {Color}");
            Console.WriteLine($"Square area is {SquareArea()}");
            Console.WriteLine($"Square perimeter is {Squareperimeter()}");
        }

        public double SquareArea()
        {
            return Line * Line;
        }
        public double Squareperimeter()
        {
            return Line * 4;
        }

        #endregion


        public double Line
        {
            get { return line; }

            set
            {
                if (value <= 0) throw new Exception("your line must be a positive number");
                else line = value;
            }
        }
    }

}
