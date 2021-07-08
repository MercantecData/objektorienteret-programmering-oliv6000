using System;

namespace DelegateTaskConsole
{
    class Program
    {
        public delegate void del1();
        public delegate float del2();
        public delegate void del3(string str, int i, float flt);

        static void Main(string[] args)
        {

            del1 handler = DelegateStringMethod;
            handler();

            del2 handler2 = DelegateFloatMethod;
            float del2Float = handler2();
            Console.WriteLine("\n" + del2Float);

            del3 handler3 = DelegateNoReturn;
            handler3("hey", 122, 1.12f);
        }

        public static void DelegateStringMethod()
        {
            Console.WriteLine("Hello world!");
        }

        public static float DelegateFloatMethod()
        {
            return 420.69f;
        }

        public static void DelegateNoReturn(string str, int i, float flt)
        {
            Console.WriteLine("\nString: " + str + "\nInt: " + i + "\nFloat: " + flt);
        }
    }
}
