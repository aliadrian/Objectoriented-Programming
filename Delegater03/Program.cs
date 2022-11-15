namespace Delegater03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> foo = IsLessThan;
            bool b = foo(2, 1);
            Console.WriteLine(b);
        }

        static bool IsLessThan(int x, int y)
        {
            if (x < y) return true;
            else return false;
        }
    }
}