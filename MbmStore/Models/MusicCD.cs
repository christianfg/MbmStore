using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        
        List<Track> tracks = new List<Track>();
        
        public string Artist
        {
            get; set;
        }
        public string Label
        {
            get; set;
        }
        public short Released
        {
            get; set;
        }
        //Read only property
        public List<Track> Tracks
        {
            get
            {
                return tracks;
            }
        } 
        //Constructors
        public MusicCD ()
        {

        }
        public MusicCD(string artist, string title, decimal price, short released, int productId) : base(title, price, productId)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Released = released;
        }
        //Method
        public void AddTrack(Track t)
        {
            tracks.Add(t);
        }
        public TimeSpan GetPlayingTime() {
            TimeSpan sum = new TimeSpan();
            foreach (Track t in tracks)
            {
                sum = t.Length + sum;
            }
            return sum;
        }
    }
}