using System;

namespace LambdaTaskConsole
{
    class Program
    {
        public delegate int del1(int i1);
        public delegate float del2(float f1, float f2, float f3);
        public delegate string del3();

        static void Main(string[] args)
        {
            del1 handler1 = x => x * x;
            Console.WriteLine("Task 1: " + handler1(5) + "\n");

            del2 handler2 = (x1, x2, x3) => x1 + x2 + x3;
            Console.WriteLine("Task 2: " + handler2(5.12f, 6.31f, 1.17f) + "\n");

            del3 handler3 = () => "hello";
            Console.WriteLine("Task 3: " + handler3());
        }
    }
}
