using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDemo
{
    public class Track
    {
        public Track(string trackName, double trackLength)
        {
            TrackName = trackName;
            TrackLength = trackLength;
        }

        public string TrackName { get; }
        public double TrackLength { get; }
    }
}
