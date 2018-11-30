﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string PlayerName { get; set; }
        public DateTime Birthday { get; set; }
        public int Number { get; set; }
    }
}