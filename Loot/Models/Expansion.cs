using System;
using System.Collections.Generic;

namespace Loot.Models
{
    public class Expansion
    {
        public enum ExpansionName
        {
            Legion = 1
        }

        public Guid Id { get; set; }
        public ExpansionName Name { get; set; }
        public ICollection<Raid> Raids { get; set; }
    }
}