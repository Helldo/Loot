using Loot.Models;
using System;
using System.Collections.Generic;
using static Loot.Models.Boss;

namespace Loot.Dal.Repositories
{
    public interface IBossRepository : IGenericRepository<Boss>
    {
        Boss GetById(Guid? id);
        IList<Boss> GetByRaidName(RaidName raidName);
    }
}