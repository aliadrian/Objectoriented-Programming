namespace AlbumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album("Ride The Lightning");
            Console.WriteLine($"Album: {album.AlbumName}");
            album.AddToListOfTrack("The Call of Ktulu", 8.53);
        }
    }
}