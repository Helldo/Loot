using Loot.Models;
using System.Data.Entity.ModelConfiguration;

namespace Loot.Dal.Configurations
{
    public class BossConfiguration : EntityTypeConfiguration<Boss>
    {
        public BossConfiguration()
        {
            ToTable("Boss");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("BossId");            
        }
    }
}