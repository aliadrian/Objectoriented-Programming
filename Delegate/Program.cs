namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileFinder fileFinder = new FileFinder();

            Console.WriteLine("Named method");
            fileFinder.GetFiles(dirPath, TextOrNot);

            Console.WriteLine();

            Console.WriteLine("Lambda expression");
            fileFinder.GetFiles(dirPath, p => Path.GetExtension(p) == ".txt");

        }

        private static bool TextOrNot(string filePath)
        {
            return Path.GetExtension(filePath) == ".txt";
        }
    }
}