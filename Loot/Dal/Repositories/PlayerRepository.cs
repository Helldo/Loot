using Loot.Models;
using System;
using System.Linq;

namespace Loot.Dal.Repositories
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(LootDbContext context) : base(context)
        {
        }

        public Player GetById(Guid? id) => Context.Players.FirstOrDefault(b => b.Id == id);
    }
}