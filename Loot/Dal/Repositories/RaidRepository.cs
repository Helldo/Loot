using Loot.Models;
using System;
using System.Linq;

namespace Loot.Dal.Repositories
{
    public class RaidRepository : GenericRepository<Raid>, IRaidRepository
    {
        public RaidRepository(LootDbContext context) : base(context)
        {
        }

        public Raid GetById(Guid? id) => Context.Raids.FirstOrDefault(b => b.Id == id);
    }
}