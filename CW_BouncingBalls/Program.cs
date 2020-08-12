using System;

namespace CW_BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new BouncingBall();
            Console.WriteLine(a.bouncingBall(30.0, 0.66, 1.5));
            Console.ReadKey();
        }
    }
}
