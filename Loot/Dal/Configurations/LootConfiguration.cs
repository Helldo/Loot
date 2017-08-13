using System.Data.Entity.ModelConfiguration;

namespace Loot.Dal.Configurations 
{
    public class LootConfiguration : EntityTypeConfiguration<Models.Loot>
    {
        public LootConfiguration()
        {
            ToTable("Loot");
            HasKey(l => l.Id);
            Property(l => l.Id).HasColumnName("LootId");
        }
    }
}