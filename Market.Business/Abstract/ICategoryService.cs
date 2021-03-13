using System.Collections.Generic;
using Market.Entity.Concrete;

namespace Market.Business.Abstract
{
   public  interface ICategoryService
   {
       List<Category> GetAll();
   }
}
