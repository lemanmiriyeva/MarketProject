using System.Linq;
using Market.Business.Abstract;
using Market.Entity.Concrete;
using Market.Entity.Domain;

namespace Market.Business.Concrete
{
   public class CartManager:ICartService
   {
        public void AddToCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.CategoryId == product.CategoryId);
            if (cartItem!=null)
            {
                cartItem.Quantity++;
            }
            else
            {
                cart.CartItems.Add(new CartItem()
                {
                    Product = product,
                    Quantity = 1
                });
            }
        }

        public void DeleteFromCart(Product product, Cart cart)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Product.CategoryId == product.CategoryId);
            cart.CartItems.Remove(cartItem);
        }
    }
}
