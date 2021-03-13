using Market.Entity.Concrete;
using Market.Entity.Domain;

namespace Market.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Product product, Cart cart);
        void DeleteFromCart(Product product, Cart cart);
    }
}
