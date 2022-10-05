using BlogDoDautin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogDoDautin.Data.Map
{
    public class PostMap : IEntityTypeConfiguration<NewsModel>
    {
        public void Configure(EntityTypeBuilder<NewsModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User);
        }
    }
}
