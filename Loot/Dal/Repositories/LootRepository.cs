using System;
using System.Linq;

namespace Loot.Dal.Repositories
{
    public class LootRepository : GenericRepository<Models.Loot>, ILootRepository
    {
        public LootRepository(LootDbContext context) : base(context)
        {
        }

        public Models.Loot GetById(Guid? id) => Context.Loots.FirstOrDefault(b => b.Id == id);
    }
}