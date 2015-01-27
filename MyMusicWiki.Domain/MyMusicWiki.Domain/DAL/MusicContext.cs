using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMusicWiki.Domain.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyMusicWiki.Domain.DAL
{
    public class MusicContext : DbContext
    {

        public MusicContext()
            : base("MusicContext")
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}