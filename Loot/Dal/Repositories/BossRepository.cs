using Loot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static Loot.Models.Boss;

namespace Loot.Dal.Repositories
{
    public class BossRepository : GenericRepository<Boss>, IBossRepository
    {
        public BossRepository(LootDbContext context) : base(context)
        {
        }

        public Boss GetById(Guid? id) => Context.Bosses.FirstOrDefault(b => b.Id == id);

        public IList<Boss> GetByRaidName(RaidName raidName) => Context.Bosses.Where(b => b.Raid == raidName).ToList();
    }
}