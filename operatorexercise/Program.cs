using System;

namespace operatorexercise
{

    class program
    {
      

        static void Main(string[] arg)
        {

            var a = 17;
            var b = 4;

            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient } remander {remainder }");
            //-----------------exercise 2---------------------//
            Console.WriteLine($"What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var pi = Math.PI;
            var areaOfcircle = pi *(radius * radius);
            Console.WriteLine();
            
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfcircle}");

        }
    }

}


