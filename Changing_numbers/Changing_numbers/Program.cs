using System;

namespace Changing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 11;
            n = n + m;
            m = n + m;
            n = m - n;
            m = m - n - n;

            Console.WriteLine(n + " " + m);
        }
    }
}
