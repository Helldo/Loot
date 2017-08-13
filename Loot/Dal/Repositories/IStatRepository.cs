using Loot.Models;
using System;

namespace Loot.Dal.Repositories
{
    public interface IStatRepository : IGenericRepository<Stat>
    {
        Stat GetById(Guid? id);
    }
}