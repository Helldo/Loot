using Loot.Models;
using System;

namespace Loot.Dal.Repositories
{
    public interface IExpansionRepository : IGenericRepository<Expansion>
    {
        Expansion GetById(Guid? id);
    }
}