using System;

namespace Loot.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsRegulier { get; set; }
        public Stat FirstStat { get; set; }
        public Stat SecondStat { get; set; }
    }
}