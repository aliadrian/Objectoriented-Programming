namespace Delegater_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> print = PrintIt;
            print("academy", true);
            print("ACADEMY", false);
        }

        static void PrintIt(string s, bool b)
        {
            if (b)
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }
    }
}