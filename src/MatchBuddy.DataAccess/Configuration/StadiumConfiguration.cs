using MatchBuddy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchBuddy.DataAccess.Configuration
{
    public class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.HasKey(x => x.StadiumId);
            builder
                .Property(b => b.StadiumName)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
