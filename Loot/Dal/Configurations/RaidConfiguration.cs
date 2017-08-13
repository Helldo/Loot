using Loot.Models;
using System.Data.Entity.ModelConfiguration;

namespace Loot.Dal.Configurations
{
    public class RaidConfiguration : EntityTypeConfiguration<Raid>
    {
        public RaidConfiguration()
        {
            ToTable("Raid");
            HasKey(r => r.Id);
            Property(r => r.Id).HasColumnName("RaidId");
        }
    }
}