using System;
using System.Collections.Generic;

namespace Loot.Models
{
    public class Raid
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}