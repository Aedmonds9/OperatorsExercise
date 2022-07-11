using System;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to add.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to add to first.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine(sum);
            
            Console.WriteLine("Give me a number to multiply");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to multiply by");
            int num4 = int.Parse(Console.ReadLine());
            int product = num3 * num4;
            Console.WriteLine("product");
            
            Console.WriteLine("Give me a number to divide");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to divide by");
            int num6= int.Parse(Console.ReadLine());
            int quotient = num5 / num6;
            Console.WriteLine("quotient");
            var remainder = num1 % num2;
            if (num5 == 17 && num6 == 4) ;
            return Console.WriteLine("17/4 is 4 remainder 1");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
          public static void AreaOfcircle(string[] r)
            {
                const double pi = 3.14;
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Area of your circle = {0}" ,pi * radius * radius);



            }



        }


        }
    }
    }
    
}
