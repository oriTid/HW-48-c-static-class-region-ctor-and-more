using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome. Please enter Circle details.");
            Console.WriteLine();


            double mycircX = GetDoubleFromUser("Enter circle X coordinates:");
            double mycircY = GetDoubleFromUser("Enter circle Y coordinates:");
            double mycircRad;
            do
            {
                mycircRad = GetDoubleFromUser("Enter circle Radius:");
                if (mycircRad <= 0) Console.WriteLine("Radius must be a positive num. Try again :");
            } while (mycircRad <= 0);

            int myCircColor = GetColorFromUser("Enter circle color:");

            Console.WriteLine();

            Circle myCircle = new Circle();

            myCircle.Radius = mycircRad;
            myCircle.XCoor = mycircX;
            myCircle.YCoor = mycircY;
            myCircle.Color = myCircColor;
            myCircle.CricleDetails();

            Console.WriteLine();
            Console.WriteLine("Now, we will proceed to generate the Sqaure.");
            Console.WriteLine();


            double mysqrX = GetDoubleFromUser("Enter Square  X coordinates:");
            double mysqrY = GetDoubleFromUser("Enter Square Y coordinates:");
            double mysqrLine;
            do
            {
                mysqrLine = GetDoubleFromUser("Enter Square Line length:");
                if (mysqrLine <= 0) Console.WriteLine("Line must be a positive num. Try again.");
            } while (mysqrLine <= 0);

            int mySqrColor = GetColorFromUser("Enter line color:");


            Console.WriteLine();

            Square mySqaure = new Square();

            mySqaure.Line = mysqrLine;
            mySqaure.XCoor = mysqrX;
            mySqaure.YCoor = mysqrY;
            mySqaure.Color = mySqrColor;
            mySqaure.SquareDetails();


            Console.WriteLine();
            Console.WriteLine($"Calc.GetSub(3, 4) : {Calc.GetSub(3, 4)}");
            Console.WriteLine($"Calc.GetSub(3, 4, 5) : {Calc.GetSub(3, 4,5)}");
            Console.WriteLine($"Calc.GetSub(3.345345345345345, 4.345345345345345) : {Calc.GetSub(3.345345345345345, 4.345345345345345)}");
            Console.ReadLine();
        }

        #region Main Functions
        static double GetDoubleFromUser(string prompt)
        {
            double userInput;
            Console.WriteLine(prompt);
            while (!double.TryParse(Console.ReadLine(), out userInput))
                Console.WriteLine("Invalid number try again");
            return userInput;
        }

        static int GetColorFromUser(string prompt)
        {
            int userInput;
            Console.WriteLine(prompt);
            while (!int.TryParse(Console.ReadLine(), out userInput))
                Console.WriteLine("Invalid number try again");
            return userInput;
        }
    }

    #endregion
}
