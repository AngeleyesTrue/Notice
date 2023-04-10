using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AE.Notice.Common.Domain.Entities;

namespace AE.Notice.Common.Infrastructure.Persistence.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<PostData>
{
    public void Configure(EntityTypeBuilder<PostData> builder)
    {
        builder.ToTable("tb_Post");

        builder.HasKey(x => x.Id);

        builder.Property(t => t.Id).IsRequired().UseIdentityColumn();
        builder.Property(t => t.Title).HasMaxLength(200).IsRequired();
        builder.Property(t => t.Content).IsRequired();
        builder.Property(t => t.CreatedBy).IsUnicode(false).HasMaxLength(200);
        builder.Property(t => t.CreatedByName).HasMaxLength(200);
        builder.Property(t => t.LastModifiedBy).IsUnicode(false).HasMaxLength(200);
        builder.Property(t => t.LastModifiedByName).HasMaxLength(200);
    }
}