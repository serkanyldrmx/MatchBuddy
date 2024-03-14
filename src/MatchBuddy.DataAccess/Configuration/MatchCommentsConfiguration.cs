using MatchBuddy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchBuddy.DataAccess.Configuration
{
    public class MatchCommentsConfiguration : IEntityTypeConfiguration<MatchComments>
    {
        public void Configure(EntityTypeBuilder<MatchComments> builder)
        {
            builder.HasKey(x => x.CommentsId);

            // UserId alanı için foreign key ilişkisi
            builder.HasOne(x => x.Player)
                   .WithMany()
                   .HasForeignKey(x => x.UserId)
                   .IsRequired();

            // MatchId alanı için foreign key ilişkisi
            builder.HasOne(x => x.Match)
                   .WithMany()
                   .HasForeignKey(x => x.MatchId)
                   .IsRequired();
        }
    }
}
