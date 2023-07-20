using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AO.Domin.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
      void Creat(ArticleCategory category);
      List<ArticleCategory> GetAll();



    }
}
