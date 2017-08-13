using Loot.Models;
using System;
using System.Linq;

namespace Loot.Dal.Repositories
{
    public class ExpansionRepository : GenericRepository<Expansion>, IExpansionRepository
    {
        public ExpansionRepository(LootDbContext context) : base(context)
        {
        }

        public Expansion GetById(Guid? id) => Context.Expansions.FirstOrDefault(b => b.Id == id);
    }
}