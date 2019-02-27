using System;

namespace IntegerLoop
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Print even integers from 0 to 50.

            //Console.WriteLine("Even integers from 0 to 50 are:");
            
            for (int i = 2; i < 51; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
