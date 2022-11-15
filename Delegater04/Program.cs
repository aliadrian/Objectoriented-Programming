using System;

namespace Delegater04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("Academy", TakeADelegate);
        }

        private static bool TakeADelegate()
        {
            return false;
        }

        static void SomeMethod(string s, Func<bool> a)
        {
            if (a())
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s.ToLower());
            }
        }
    }
}