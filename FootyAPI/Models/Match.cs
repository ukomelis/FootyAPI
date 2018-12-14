﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Models
{
    public class Match
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public List<Goal> Goals { get; set; }
        public List<Booking> Bookings { get; set; }
        public string Score { get; set; }
        public Venue Venue { get; set; }
        public DateTime DateTime { get; set; }
        public string Referee { get; set; }
        public Competition Competition { get; set; }
    }
}
