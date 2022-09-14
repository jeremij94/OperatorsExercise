using System;
namespace OperatorExercise
{
    public class Methods
    {
       public static void Exercise1()
        {
            // Exercise 1 Math Operators. For divison, create two int variables called a and b. 



            int a = 17;
            int b = 4;
            var quotient = a /= b;
            var remainder = a %= b;

            Console.WriteLine($" {a} / {b} is {quotient} with a remainder of {remainder}");

            int sum = a += b;
            Console.WriteLine($"{a} + {b} equals {sum}.");

            int difference = a -= b;
            Console.WriteLine($"The difference between {a} - {b} equals {difference}.");

            int product = a *= b;
            Console.WriteLine($"{a} times {b} equals {product}.");

        }

        public static double AreaOfCircle(double radius)
            {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
            }
    }
}

