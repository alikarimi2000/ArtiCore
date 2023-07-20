using AO.Domin.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AO.Infrastructure.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ArtiCoreContext context;

        public ArticleCategoryRepository(ArtiCoreContext context)
        {
            this.context = context;
        }

        public void Creat(ArticleCategory category)
        {
            context.ArticleCategories.Add(category);
        }

        public List<ArticleCategory> GetAll()
        {
           return context.ArticleCategories.ToList();
        }
    }
}
