using Loot.Models;
using System.Data.Entity.ModelConfiguration;

namespace Loot.Dal.Configurations
{
    public class ExpansionConfiguration : EntityTypeConfiguration<Expansion>
    {
        public ExpansionConfiguration()
        {
            ToTable("Expansion");
            HasKey(e => e.Id);
            Property(e => e.Id).HasColumnName("ExpansionId");            
        }
    }
}