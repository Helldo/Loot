using Loot.Models;
using System.Data.Entity.ModelConfiguration;

namespace Loot.Dal.Configurations
{
    public class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        public PlayerConfiguration()
        {
            ToTable("Player");
            HasKey(p => p.Id);
            Property(p => p.Id).HasColumnName("PlayerId");
        }
    }
}