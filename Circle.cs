using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Circle
    {
        public double XCoor { get; set; }
        public double YCoor { get; set; }
        public int Color { get; set; }
        private double radius;

        public Circle()
        {
            Console.WriteLine("A circle was created !!! one day, you will even get to see it");
        }

        #region Circle Functions
        public void CricleDetails()
        {
            Console.WriteLine($"Circle radius is {Radius}");
            Console.WriteLine($"Circle x Coordiante is {XCoor}");
            Console.WriteLine($"Circle y Coordiante is {YCoor}");
            Console.WriteLine($"Circle color-code is {Color}");
            Console.WriteLine($"Circle area is {CircleArea()}");
            Console.WriteLine($"Circle ceumference is {CircleCircumference()}");
        }
        public double CircleArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double CircleCircumference()
        {
            return Radius * 2 * Math.PI;
        }
        
        #endregion
        public double Radius
        {
            get { return radius; }

            set
            {
                if (value <= 0) throw new Exception("your radius must be a positive number");
                else radius = value;
            }
        }
    }
}
