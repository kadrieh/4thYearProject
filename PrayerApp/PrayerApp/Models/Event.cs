using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string EventPlace { get; set; }
        public User User { get; set; }
    }
}