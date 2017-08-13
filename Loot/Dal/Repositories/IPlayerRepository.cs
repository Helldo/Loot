using Loot.Models;
using System;

namespace Loot.Dal.Repositories
{
    public interface IPlayerRepository : IGenericRepository<Player>
    {
        Player GetById(Guid? id);
    }
}