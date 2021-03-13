using Market.Business.Abstract;
using Market.MVCWebUI2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Market.MVCWebUI2.Controllers
{
    public class ProductController:Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model=new ProductListViewModel
            {
                Products = category>0?_productService.GetByCategoryId(category): _productService.GetAll()
            };
            return View(model);
        }
    }
}
