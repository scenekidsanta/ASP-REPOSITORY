using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicWiki.Domain.Models
{
    public class Leaderboard
    {
        public int LeaderboardID { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
    }
}