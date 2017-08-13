using System;
using System.ComponentModel;

namespace Loot.Models
{
    public class Boss
    {
        public enum RaidName
        {
            [Description("Tombe De Sargeras")] TombeDeSargeras = 1
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public RaidName Raid { get; set; }
    }
}