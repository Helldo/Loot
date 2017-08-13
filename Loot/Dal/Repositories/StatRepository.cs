using Loot.Models;
using System;
using System.Linq;

namespace Loot.Dal.Repositories
{
    public class StatRepository : GenericRepository<Stat>, IStatRepository
    {
        public StatRepository(LootDbContext context) : base(context)
        {
        }

        public Stat GetById(Guid? id) => Context.Stats.FirstOrDefault(b => b.Id == id);
    }
}