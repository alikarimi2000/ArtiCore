using AO.ApplicationContracts.ArticleCategory;
using AO.Domin.ArticleCategoryAgg;

namespace AO.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository articleCategoryRepository;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            this.articleCategoryRepository = articleCategoryRepository;
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
           var articlecategories= articleCategoryRepository.GetAll();
            var result= new List<ArticleCategoryViewModel>();
            foreach (var articlecategory in articlecategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = articlecategory.Id,
                    Title = articlecategory.Title,
                    CreationDate = articlecategory.CreationDate.ToString(),
                    IsDeleted = articlecategory.IsRemove

                });

            }

            return result;

        }
    }
}