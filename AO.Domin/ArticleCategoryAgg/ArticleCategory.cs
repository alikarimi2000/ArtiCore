using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AO.Domin.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id  { get;private set; }
        public string Title { get;private set; }
        public bool IsRemove { get;private set; }
        public DateTime CreationDate { get;private set; }

        public ArticleCategory(string title)
        {
            Title = title;
            IsRemove = false;
            CreationDate = DateTime.Now;
        }
    }
}
