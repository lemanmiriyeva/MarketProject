using Market.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Market.MVCWebUI2.Controllers
{
    public class CategoryController:Controller
    {
        public ICategoryService CategoryService { get; }

        public CategoryController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }

    }
}
