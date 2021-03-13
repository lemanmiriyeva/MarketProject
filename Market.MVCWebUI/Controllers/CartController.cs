using Microsoft.AspNetCore.Mvc;
using Market.Business.Abstract;
using Market.MVCWebUI.Helper;
using Market.MVCWebUI.Models;

namespace Market.MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartSessionHelper _cartSessionHelper;
        private readonly ICartService _cartService;
        private readonly IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult Index()
        {
            
            CartListViewModel cartListViewModel = new CartListViewModel()
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(cartListViewModel);
        }


        public IActionResult AddToCart(int id)
        {
            var product = _productService.GetById(id);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(product, cart);
            _cartSessionHelper.SetCart("cart",cart);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var product = _productService.GetById(id);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.DeleteFromCart(product,cart);
            _cartSessionHelper.SetCart("cart",cart);
            return RedirectToAction("Index", "Cart");
        }
    }
}
