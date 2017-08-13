using Loot.Dal.Configurations;
using Loot.Models;
using System.Data.Entity;

namespace Loot.Dal
{
    public class LootDbContext : DbContext
    {
        public LootDbContext() : base("Loot")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public virtual IDbSet<Boss> Bosses { get; set; }
        public virtual IDbSet<Expansion> Expansions { get; set; }
        public virtual IDbSet<Models.Loot> Loots { get; set; }
        public virtual IDbSet<Player> Players { get; set; }
        public virtual IDbSet<Raid> Raids { get; set; }
        public virtual IDbSet<Stat> Stats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BossConfiguration());
            modelBuilder.Configurations.Add(new ExpansionConfiguration());
            modelBuilder.Configurations.Add(new LootConfiguration());
            modelBuilder.Configurations.Add(new PlayerConfiguration());
            modelBuilder.Configurations.Add(new RaidConfiguration());
            modelBuilder.Configurations.Add(new StatConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}