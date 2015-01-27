using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MyMusicWiki.Domain.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string albumName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Songs { get; set; }

        public virtual ICollection<Song> Song { get; set; }
    }
}