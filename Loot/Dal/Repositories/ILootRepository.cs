using System;

namespace Loot.Dal.Repositories
{
    public interface ILootRepository : IGenericRepository<Models.Loot>
    {
        Models.Loot GetById(Guid? id);
    }
}