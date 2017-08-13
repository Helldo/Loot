using Loot.Models;
using System.Data.Entity.ModelConfiguration;

namespace Loot.Dal.Configurations
{
    public class StatConfiguration : EntityTypeConfiguration<Stat>
    {
        public StatConfiguration()
        {
            ToTable("Stat");
            HasKey(s => s.Id);
            Property(s => s.Id).HasColumnName("StatId");
        }
    }
}