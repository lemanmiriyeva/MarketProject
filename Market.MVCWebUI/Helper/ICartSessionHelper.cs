using Market.Entity.Domain;

namespace Market.MVCWebUI.Helper
{
    public interface ICartSessionHelper
    {
         Cart GetCart(string key);
         void SetCart(string key, Cart cart);
         void Clear();
    }
}
