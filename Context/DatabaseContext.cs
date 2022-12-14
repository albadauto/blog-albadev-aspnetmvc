using BlogDoDautin.Data.Map;
using BlogDoDautin.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogDoDautin.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserModel> User { get; set; }
        public DbSet<NewsModel> News { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
