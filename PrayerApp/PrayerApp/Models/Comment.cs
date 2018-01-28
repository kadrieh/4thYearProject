using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string userComment { get; set; }

        public List<Stage> Stages { get; set;
        }
    }
}