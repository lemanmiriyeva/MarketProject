using Core.DataAccess.Abstract;
using Market.Entity.Concrete;

namespace Market.Entity.Domain
{
    public class CartItem:IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
