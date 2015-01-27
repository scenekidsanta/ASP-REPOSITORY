using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyMusicWiki.Domain.Models;
namespace MyMusicWiki.Domain.DAL
{
    public class MusicInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artists = new List<Artist>
            {
            new Artist{ArtistID= 1, ArtistName="Skylight Avenue"},
            new Artist{ArtistID= 2, ArtistName="Relient K"},
            };

            artists.ForEach(s => context.Artists.Add(s));
            context.SaveChanges();
            var albums = new List<Album>
            {
            new Album{AlbumID = 1 , albumName="The View From Here", Genre="Pop-Punk", ReleaseDate=DateTime.Parse("2013-09-01")},
            new Album{AlbumID = 2 , albumName="The Anatomy of Tongue in Cheek", Genre="Pop-Rock", ReleaseDate=DateTime.Parse("2004-10-21")},
            };
            albums.ForEach(s => context.Albums.Add(s));
            context.SaveChanges();

            var songs = new List<Song>
            {
                new Song{SongID=1,SongName="This City Never Sleeps", AlbumID = 1, ArtistID= 1, Genre="Pop-Punk", Length= 4.23}
            };
            songs.ForEach(s => context.Songs.Add(s));
            context.SaveChanges();
        }
    }
}