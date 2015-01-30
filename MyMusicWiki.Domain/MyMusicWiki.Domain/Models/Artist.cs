using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMusicWiki.Domain.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Song> Song { get; set; }
    }
}