﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityBot.Entities
{
    public class GlobalUserAccount : IGlobalAccount
    {
        public ulong Id { get; set; }

        public ulong Miunies { get; set; }

        public DateTime LastDaily { get; set; } = DateTime.UtcNow.AddDays(-2);

        public DateTime LastMessage { get; set; } = DateTime.UtcNow;

        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>();
        /* Add more values to store */
    }
}
