using System.Collections.Generic;
using Market.Entity.Concrete;

namespace Market.Business.Abstract
{
   public interface IProductService
   {
        List<Product> GetAll();
        List<Product> GetByName(string name);
        List<Product> GetByCategoryId(int id);
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        
   }
}
