using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDemo
{
    public class Album
    {
        public string AlbumName { get; }

        List<Track> tracks = new List<Track>();
        public Album(string albumName)
        {
            AlbumName = albumName;
        }

        public void AddToListOfTrack(string trackName, double trackLength)
        {
            Track track = new Track(trackName, trackLength);
            tracks.Add(track);

            foreach (Track item in tracks)
            {
                Console.WriteLine($"Track name: {item.TrackName}\nTrack length: {item.TrackLength}");
            }
        }
    }
}
