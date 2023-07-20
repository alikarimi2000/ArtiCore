using AO.Domin.ArticleCategoryAgg;
using AO.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AO.Infrastructure
{
    public class ArtiCoreContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public ArtiCoreContext(DbContextOptions<ArtiCoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}