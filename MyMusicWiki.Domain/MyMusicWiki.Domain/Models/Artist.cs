using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicWiki.Domain.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }

        public virtual Album Album { get; set; }
    }
}