using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicWiki.Domain.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public int AlbumID { get; set; }
        public int ArtistID { get; set; }
        public string SongName { get; set; }
        public string Genre { get; set; }
        public double Length { get; set; }
        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }
    }
}