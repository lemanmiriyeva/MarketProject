using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Market.Business.Abstract;
using Market.Entity.Concrete;
using Market.MVCWebUI.Models;

namespace Market.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public List<Product> GetByName(object sender,EventArgs e)
        {
            return new List<Product>();
        }
        public IActionResult Index(int id)
        {
            var productListViewModel = new ProductListViewModel()
            {
                Products = id > 0 && id<9 ? _productService.GetByCategoryId(id) : _productService.GetAll(),
                Categories = _categoryService.GetAll(),
                CurrentCategoryId = id
                
            };
            
        return View(productListViewModel);
        }
    }
}
