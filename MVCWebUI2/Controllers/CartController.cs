using Market.Business.Abstract;
using Market.Entity.Concrete;
using Market.MVCWebUI2.Helpers;
using Market.MVCWebUI2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Market.MVCWebUI2.Controllers
{
    public class CartController:Controller
    {
        private readonly ICartService _cartService;
        private readonly ICartSessionHelper _cartSessionHelper;
        private readonly IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(product,cart);
            _cartSessionHelper.SetCart("cart",cart);
            TempData.Add("message",product.ProductName + " sepete eklendi!");
            return RedirectToAction("Index", "Product");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.DeleteFromCart(product,cart);
            _cartSessionHelper.SetCart("cart", cart);
            TempData.Add("message", product.ProductName + " sepetten silindi!");
            return RedirectToAction("Index", "Cart");

        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }

        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail=new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message","Siparişiniz başarıyla tamamlandı!");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Cart");
        }
    }
}
