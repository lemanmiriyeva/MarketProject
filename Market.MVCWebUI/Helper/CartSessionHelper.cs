using Market.Entity.Domain;
using Market.MVCWebUI.Extensions;
using Microsoft.AspNetCore.Http;

namespace Market.MVCWebUI.Helper
{
    public class CartSessionHelper:ICartSessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart(string key)
        {
           var cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
           if (cart == null)
           {
               SetCart(key, new Cart());
               cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
           }
           return cart;
        }

        public void SetCart(string key, Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key,cart);
        }

        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }

    }
}
