using Loot.Models;
using System;

namespace Loot.Dal.Repositories
{
    public interface IRaidRepository : IGenericRepository<Raid>
    {
        Raid GetById(Guid? id);
    }
}