using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class ArticleVisitorMap : IEntityTypeConfiguration<ArticleVisitor>
    {
        public void Configure(EntityTypeBuilder<ArticleVisitor> builder)
        {
            builder.HasKey(x => new { x.ArticleId, x.VisitorId });
        }
    }
}