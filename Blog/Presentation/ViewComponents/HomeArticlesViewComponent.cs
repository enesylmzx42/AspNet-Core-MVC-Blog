using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace Presentation.ViewComponents
{
    public class HomeArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public HomeArticlesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await articleService.GetAllCategoriesNonDeletedTake3();
            return View(articles);
        }
    }
}