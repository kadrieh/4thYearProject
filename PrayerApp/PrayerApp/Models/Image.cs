using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerApp.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Event Event { get; set; }
    }
}