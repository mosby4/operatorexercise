using System;

namespace operatorexercise
{

    class program
    {
      

        static void Main(string[] arg)
        {

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remander {mod}");
            //-----------------exercise 2---------------------//

            var r = 20;
            var pi = Math.PI;

            var areaOfcircle = pi *(r*r);

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfcircle}");

        }
    }

}


