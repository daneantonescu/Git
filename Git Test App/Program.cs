using System;

namespace Git_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Git Test App v0.0.00.001");

            Console.WriteLine("Feature A.02");
            Console.WriteLine("Feature B.02");

            Console.WriteLine("Feature C.01");

            MakeSomething();

            Console.Read();
        }


        private static void MakeSomething()
        {
            Console.WriteLine("Feature E.01");
        }
    }
}
