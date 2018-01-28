using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrayerApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<PrayerList> PrayerList { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        //public System.Data.Entity.DbSet<DotNetAppSqlDb.Models.Todo> Todoes { get; set; }

        public DatabaseContext()
            : base("name=DefaultConnection")
        { }

        public System.Data.Entity.DbSet<PrayerApp.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<PrayerApp.Models.Pilgramage> Pilgramages { get; set; }

        public System.Data.Entity.DbSet<PrayerApp.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<PrayerApp.Models.Image> Images { get; set; }

        public System.Data.Entity.DbSet<PrayerApp.Models.FavouritePrayer> FavouritePrayers { get; set; }

        //public System.Data.Entity.DbSet<PrayerList.Models.Pilgramage> Pilgramages { get; set; }
    }
}