using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerApp.Models
{
    public class FavouritePrayer
    {
        public int Id { get; set; }
        public string PrayerName { get; set; }

        public List<User> Users { get; set; }
    }
}