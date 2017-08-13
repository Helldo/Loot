using System;

namespace Loot.Models
{
    public class Stat
    {
        public enum StatName
        {
            Maitrise = 1,
            Hate = 2,
            Critique = 3,
            Polyvalence = 4
        }

        public Guid Id { get; set; }
        public StatName Name { get; set; }
    }
}