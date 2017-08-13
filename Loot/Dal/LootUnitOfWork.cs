using Loot.Dal.Repositories;
using System;

namespace Loot.Dal
{
    public class LootUnitOfWork : ILootUnitOfWork
    {
        private readonly LootDbContext context;
        private bool disposed;
        private IBossRepository bossRepository;
        private IExpansionRepository expansionRepository;
        private ILootRepository lootRepository;
        private IPlayerRepository playerRepository;
        private IRaidRepository raidRepository;
        private IStatRepository statRepository;
        
        public LootUnitOfWork(LootDbContext context)
        {
            this.context = context;
        }

        public IBossRepository BossRepository => bossRepository ?? (bossRepository = new BossRepository(context));
        public IExpansionRepository ExpansionRepository => expansionRepository ?? (expansionRepository = new ExpansionRepository(context));
        public ILootRepository LootRepository =>  lootRepository ?? (lootRepository = new LootRepository(context));
        public IPlayerRepository PlayerRepository => playerRepository ?? (playerRepository = new PlayerRepository(context));
        public IRaidRepository RaidRepository => raidRepository ?? (raidRepository = new RaidRepository(context));
        public IStatRepository StatRepository => statRepository ?? (statRepository = new StatRepository(context));

        public void Save() => context.SaveChanges();

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
                context.Dispose();

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}